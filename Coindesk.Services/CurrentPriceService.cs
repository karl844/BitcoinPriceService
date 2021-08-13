using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Coindesk.Services
{
    public class CurrentPriceService
    {
        public string GetCurrentPriceEuro()
        {
            using (var client = new WebClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var currPrice = client.DownloadString("https://api.coindesk.com/v1/bpi/currentprice.json");
                var coinDesk = JsonConvert.DeserializeObject<Coindesk>(currPrice);

                return $"BTC Price {coinDesk.Bpi.EUR.Code} {coinDesk.Bpi.EUR.Rate}"; 
            }
        }
    }
}
