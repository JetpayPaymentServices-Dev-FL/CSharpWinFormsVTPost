using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtRedirectWinForms
{
    class vtResponse
    {
        public class VT_TRANSACTION
        {
            [JsonProperty(PropertyName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [JsonProperty(PropertyName = "status")]
            public string status { get; set; }
        }
    }
}
