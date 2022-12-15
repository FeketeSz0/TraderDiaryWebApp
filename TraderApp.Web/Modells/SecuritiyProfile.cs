using AutoMapper;
using System.Security.Permissions;
using TraderApp.Model;

namespace TraderApp.Web.Modells
{
    public class SecuritiyProfile : Profile
    {
        public SecuritiyProfile()
        {
            CreateMap<Securities, EditFormModel>();
            CreateMap<EditFormModel, Securities>();
        
        }
    }
}
