using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class MensagemMappingProfile : Profile
    {
        public MensagemMappingProfile()
        {
            CreateMap<MensagemModel, tb_mensagem>()
                .ForMember(x => x.txt_mensagem, x => x.MapFrom(y => y.TextoMensagem))
                .ForMember(x => x.idt_equipe, x => x.MapFrom(y => y.Equipe))
                .ForMember(x => x.dta_envio, x => x.MapFrom(y => y.DataEnvio))
                .ForMember(x => x.idt_usuario, x => x.MapFrom(y => y.Usuario));
        }
    }
}
