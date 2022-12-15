using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraderApp.Model;
using TraderApp.Web.Services;

namespace TraderApp.Web.Pages
{
    public class DisplayIndividualBase : ComponentBase
    {
        [Parameter]
        public Securities Securitiy { get; set; } = new Securities();
        public Boolean isEdit { get; set; }

        public double profit { get; set; }
        public string profitCss { get; set; }
     
        [Inject]
        public ISecuService isecuservice { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            profit = Math.Round(Securitiy.SoldPrice - Securitiy.BoughtPrice, 2);
            if (profit < 0) { profitCss = "badprofit"; }
            else{
                profitCss = "goodprofit";
            }
           

        }

        public void editbutton() {
            if (isEdit == false) { isEdit = true; }
            else {isEdit = false; }

        }
        public void deleteButton() {
            isecuservice.deleteSecuritites(Securitiy.id);
            NavigationManager.NavigateTo("/", true);
        
        }




    }

 
}
