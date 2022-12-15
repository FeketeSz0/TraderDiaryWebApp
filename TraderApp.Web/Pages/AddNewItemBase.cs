using AutoMapper;
using Microsoft.AspNetCore.Components;
using TraderApp.Model;
using TraderApp.Web.Modells;
using TraderApp.Web.Services;

namespace TraderApp.Web.Pages
{
    public class AddNewItemBase : ComponentBase
    {
        public EditFormModel editFormModel { get; set; } = new EditFormModel();
        public Securities securities { get; set; } = new Securities();
        [Inject]
        ISecuService iSecuService { get; set; }
        [Inject]
        NavigationManager navigation { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        protected async Task HandleValidSubmit() {
            try { 
            editFormModel.SoldPrice = null;
            Mapper.Map(editFormModel, securities);
            await iSecuService.addSecuritites(securities);
            navigation.NavigateTo("/", true);
            }
            catch {  }
        }

       
    }

}
