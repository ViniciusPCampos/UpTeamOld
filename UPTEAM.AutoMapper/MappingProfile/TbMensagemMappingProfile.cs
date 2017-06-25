using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    class TbMensagemMappingProfile : Profile
    {
        public TbMensagemMappingProfile()
        {
            CreateMap<tb_mensagem, MensagemModel>()
                .ForMember(x => x.TextoMensagem, x => x.MapFrom(y => y.txt_mensagem))
                .ForMember(x => x.Equipe, x => x.MapFrom(y => y.idt_equipe))
                .ForMember(x => x.DataEnvio, x => x.MapFrom(y => y.dta_envio))
                .ForMember(x => x.Usuario, x => x.MapFrom(y => y.tb_usuario));
        }
    }
}
