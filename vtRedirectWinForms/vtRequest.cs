using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtRedirectWinForms
{
    class vtRequest
    {
        public class LineItem
        {
            [DisplayName("Indentifiers")]
            [JsonProperty(PropertyName = "IDENTIFIERS")]
            public List<string> identifiers { get; set; }
            [DisplayName("Amount")]
            [JsonProperty(PropertyName = "AMOUNT")]
            public double amount { get; set; }
            [DisplayName("Payment Type")]
            [JsonProperty(PropertyName = "PAYMENTTYPE")]
            public string paymentType { get; set; }
        }

        public class VT_TRANSACTION
        {
            [DisplayName("Client Key")]
            [JsonProperty(PropertyName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [DisplayName("Transaction Identifier")]
            [JsonProperty(PropertyName = "TRANSACTIONIDENTIFIER")]
            public string TRANSACTIONIDENTIFIER { get; set; }
            [DisplayName("Collection Mode")]
            [JsonProperty(PropertyName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            [JsonProperty(PropertyName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [DisplayName("Name")]
            [JsonProperty(PropertyName = "NAME")]
            public string NAME { get; set; }
            [DisplayName("Address")]
            [JsonProperty(PropertyName = "ADDRESS")]
            public string ADDRESS { get; set; }
            [DisplayName("Address Two")]
            [JsonProperty(PropertyName = "ADDRESSTWO")]
            public string ADDRESSTWO { get; set; }
            [DisplayName("City")]
            [JsonProperty(PropertyName = "CITY")]
            public string CITY { get; set; }
            [DisplayName("County")]
            [JsonProperty(PropertyName = "COUNTY")]
            public string COUNTY { get; set; }
            [DisplayName("State")]
            [JsonProperty(PropertyName = "STATE")]
            public string STATE { get; set; }
            [DisplayName("Country")]
            [JsonProperty(PropertyName = "COUNTRY")]
            public string COUNTRY { get; set; }
            [DisplayName("Zip Code")]
            [JsonProperty(PropertyName = "ZIP")]
            public string ZIP { get; set; }
            [DisplayName("Email Address")]
            [JsonProperty(PropertyName = "EMAIL")]
            public string EMAIL { get; set; }
            [DisplayName("Mobile Number")]
            [JsonProperty(PropertyName = "PHONE")]
            public string PHONE { get; set; }
            [DisplayName("Notes")]
            [JsonProperty(PropertyName = "NOTES")]
            public string NOTES { get; set; }
            [DisplayName("CSI User Identifier")]
            [JsonProperty(PropertyName = "CSIUSERID")]
            public string CSIUSERID { get; set; }
            [JsonProperty(PropertyName = "LINEITEM")]
            public List<LineItem> LINEITEMS { get; set; }
            [DisplayName("URL Silent Post")]
            [JsonProperty(PropertyName = "URLSILENTPOST")]
            public string URLSILENTPOST { get; set; }
            [JsonProperty(PropertyName = "URLRETURNPOST")]
            public string URLRETURNPOST { get; set; }
            [JsonProperty(PropertyName = "ALLOWEDPAYMENTMETHOD")]
            public string ALLOWEDPAYMENTMETHOD { get; set; }
        }
    }
}
