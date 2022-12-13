using Microsoft.AspNetCore.Components;
using TraderApp.Model;
using TraderApp.Web.Services;

namespace TraderApp.Web.Pages
{
    public class ListPortfolioBase : ComponentBase
    {
        [Inject]
        public ISecuService isSecuServiceis { get; set; }
        [Parameter]
        public Securities security { get; set; }
        public IEnumerable<Securities> securities { get; set; }

        protected override async Task OnInitializedAsync()
        {
           securities =  ( await isSecuServiceis.getSecurities()).ToList();
            
        }
    }
}
