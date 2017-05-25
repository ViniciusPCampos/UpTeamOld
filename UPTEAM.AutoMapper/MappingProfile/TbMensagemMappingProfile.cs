using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class TbMensagemMappingProfile : Profile
    {
        public TbMensagemMappingProfile()
        {
            CreateMap<MensagemModel, tb_mensagem>()
                .ForMember(x => x.txt_mensagem, x => x.MapFrom(y => y.TextoMensagem))
                .ForMember(x => x.idt_equipe, x => x.MapFrom(y => y.Equipe)).ReverseMap();
        }
    }
}
