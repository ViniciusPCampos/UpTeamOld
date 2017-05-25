using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    class MensagemMappingProfile : Profile
    {
        public MensagemMappingProfile()
        {
            CreateMap<tb_mensagem, MensagemModel>()
                .ForMember(x => x.TextoMensagem, x => x.MapFrom(y => y.txt_mensagem))
                .ForMember(x => x.Equipe, x => x.MapFrom(y => y.idt_equipe)).ReverseMap();
        }
    }
}
