using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Presentation.Web.ViewModels;

namespace UPTEAM.Presentation.Web.AutoMapper
{

    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
               CreateMap<tb_usuario, UsuarioViewModel>();
        }
    }
}