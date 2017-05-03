using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Presentation.Web.ViewModels;

namespace UPTEAM.Presentation.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, tb_usuario>();
        }
    }
}