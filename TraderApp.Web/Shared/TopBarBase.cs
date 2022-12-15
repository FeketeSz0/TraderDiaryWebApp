using Microsoft.AspNetCore.Components;
using TraderApp.Model;
using TraderApp.Web.Services;

namespace TraderApp.Web.Shared
{
    public class TopBarBase : ComponentBase
    {
        [Inject]
        public ISecuService isSecuServiceis { get; set; }
        [Inject]
        public IStockService istockserivce { get; set; }

        public IEnumerable<Securities> securities { get; set; }
        public double profit { get; set; }
        public string cssclass { get; set; }
  
       
     
        protected override async Task OnInitializedAsync()
        {
           

            securities = (await isSecuServiceis.getSecurities()).ToList();
            foreach (var s in securities) {
              profit +=  s.SoldPrice - s.BoughtPrice;

            }
            if (profit > 0) { cssclass = "goodprofit"; } else { cssclass = "badprofit"; }
            
        }

      

    }
}
