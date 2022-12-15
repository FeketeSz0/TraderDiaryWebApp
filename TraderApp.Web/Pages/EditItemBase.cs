using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using TraderApp.Model;
using TraderApp.Web.Modells;
using TraderApp.Web.Services;

namespace TraderApp.Web.Pages
{
    public class EditItemBase: ComponentBase
    {
        public EditFormModel editformmodel { get; set; } = new EditFormModel();

        [Parameter]
        public Securities securities { get; set; }
        [Inject]
        ISecuService iSecuService { get; set; }
        [Inject]
        NavigationManager navigation { get; set; }
        [Inject]
        IMapper Mapper { get; set; }
        public bool isEditMode { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Mapper.Map(securities, editformmodel);
        }

        protected async Task Edit_Button()
        {
                
                Mapper.Map(editformmodel, securities);
                await iSecuService.updateSecurity(securities);
                navigation.NavigateTo("/", true);
            
           
           
        }


    }
}
