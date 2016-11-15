using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtRedirectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private RestClient client = new RestClient("https://stage.collectorsolutions.com/magic-api/");
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //use TLS1.2
                var request = new RestRequest("api/transaction/redirect", Method.POST) { RequestFormat = DataFormat.Json };
                //object built here to be converted to json (what is sent to the web post)
                //This is our line item object build, broken out in a couple differnt objects//
                var identifiersDesc = new List<String>();
                identifiersDesc.Add(txtPaymentIDOne.Text);

                var vtRequestLineItemBody = new vtRequest.LineItem
                {
                    paymentType = txtPaymentType.Text,
                    identifiers = identifiersDesc,
                    amount = Convert.ToDouble(txtPaymentIDAmount.Text),
                };
                //End line item object build//
                var vtRequestBody = new vtRequest.VT_TRANSACTION
                {
                    CLIENTKEY = txtClientKey.Text,
                    TRANSACTIONIDENTIFIER = txtTransactionID.Text,
                    AMOUNT = txtTotalAmount.Text,
                    LINEITEMS = new List<vtRequest.LineItem>()
                    {
                        vtRequestLineItemBody
                    },
                    NAME = txtName.Text,
                    ADDRESS = txtAddress.Text,
                    CITY = txtCity.Text,
                    STATE = txtState.Text,
                    //control not in webform but shown as a way to hardcode values in if needed...
                    ZIP = "32503",
                    COLLECTIONMODE = "1",
                    CSIUSERID = "1",
                    URLSILENTPOST = "",
                    //end control comment//
                    COUNTRY = txtCountry.Text,
                    EMAIL = txtEmail.Text,
                    PHONE = txtPhone.Text,
                    NOTES = txtNotes.Text,
                };
                request.AddBody(vtRequestBody);
                var response = client.Execute(request);
                //here I am assinging the json response back to object format so we can access all the different props like: feeamount, reponsecode, etc
                vtResponse.VT_TRANSACTION vtResponseBody = JsonConvert.DeserializeObject<vtResponse.VT_TRANSACTION>(response.Content);
                txtResponse.Text = vtResponseBody.status.ToString();
            }
            catch (Exception)
            {
                //error
            }
        }
    }
}
