using Newtonsoft.Json.Linq;
using RestSharp;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace TraderApp.Web.Services
{
    public class StockService : IStockService
    {

        private readonly string apikey = "bKGaDxDDzrb0bZOMvpxZ3BFnAGKsWcwq";
        public string stockPrice { get; set; } 
        public string tag { get; set; }

        public event Action OnChange;

        public void getStockPrice()
        {
            if (tag != null && tag != string.Empty) { 
                
            var client = new RestClient("https://api.polygon.io/v2/aggs/ticker/");
            var request = new RestRequest(
                $"{tag.ToUpper()}/prev?adjusted=true&apiKey={apikey}",
                (Method)DataFormat.Json);
            
            var response = client.Get(request);
            var json = JObject.Parse(response.Content);
                var resultcount = json["resultsCount"];
                if (resultcount.ToString() == "0") {
                    stockPrice = "not a valid tag";
                    return;
                }
                var status = json["status"].ToString();
                if (status != "ERROR")
                {
                   
                    var price = json["results"][0]["o"].ToString();
                    Math.Round(Double.Parse(price), 2);
                    stockPrice = price.ToString();
                    
                 
                }
                else {
                    stockPrice = "Too much request";
                   
                }
            }
           
        }

    
    }
}
