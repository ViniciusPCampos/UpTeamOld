using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<tb_usuario, UsuarioModel>()
              .ForMember(x => x.Nome, x => x.MapFrom(y => y.nme_usuario))
              .ForMember(x => x.Telefone, x => x.MapFrom(y => y.tel_usuario))
              .ForMember(x => x.Login, x => x.MapFrom(y => y.lgn_usuario))
              .ForMember(x => x.Experiencia, x => x.MapFrom(y => y.exp_usuario))
              .ForMember(x => x.IdNivel, x => x.MapFrom(y => y.idt_nivel)).ReverseMap();
            CreateMap<RegistrarModel, tb_usuario>()
                .ForMember(x => x.email_usuario, x => x.MapFrom(y => y.Email))
                .ForMember(x => x.lgn_usuario, x => x.MapFrom( y => y.Login))
                .ForMember(x => x.nme_usuario, x => x.MapFrom( y => y.Nome))
                .ForMember(x => x.pwd_usuario, x => x.MapFrom( y => y.Senha))
                .ForMember(x => x.tel_usuario, x=> x.MapFrom( y => y.Telefone))
                .ReverseMap();
        }
    }
}
