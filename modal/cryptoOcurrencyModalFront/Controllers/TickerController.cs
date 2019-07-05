using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cryptoOcurrencyModalFront.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace cryptoOcurrencyModalFront.Controllers
{
    public class TickerController : Controller
    {
        public ActionResult GetExchanges(string from = "", string to="")
        {
            TickerPropertyModel data = null;
            string apiUrl = "";
            if(from == "" || to == ""){
                apiUrl = "https://api.cryptonator.com/api/full/btc-usd";    
            }
            else{
                apiUrl = "https://api.cryptonator.com/api/full/"+from+"-"+to;
            }
            

            using (HttpClient client=new HttpClient())
            {
                Task<String> response = client.GetStringAsync(apiUrl);
                data = JsonConvert.DeserializeObject<TickerPropertyModel>(response.Result);
            }
        return View(data);    
      }    
    }
}