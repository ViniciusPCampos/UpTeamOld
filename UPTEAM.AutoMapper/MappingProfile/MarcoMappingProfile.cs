using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class MarcoMappingProfile : Profile
    {
        public MarcoMappingProfile()
        {
            CreateMap<MarcoModel, tb_marco>()
                .ForMember(x => x.idt_marco, x => x.MapFrom(y => y.IdMarco))
                .ForMember(x => x.nme_marco, x => x.MapFrom(y => y.NomeMarco))
                .ForMember(x => x.dsc_marco, x => x.MapFrom(y => y.Descricao))
                .ForMember(x => x.dln_marco, x => x.MapFrom(y => y.Deadline))
                .ForMember(x => x.idt_projeto, x => x.MapFrom(y => y.Projeto));
            CreateMap<tb_marco, MarcoModel>()
                .ForMember(x => x.IdMarco, x => x.MapFrom(y => y.idt_marco))
                .ForMember(x => x.Projeto, x => x.MapFrom(y => y.idt_projeto))
                .ForMember(x => x.Deadline, x => x.MapFrom(y => y.dln_marco))
                .ForMember(x => x.Descricao, x => x.MapFrom(y => y.dsc_marco))
                .ForMember(x => x.NomeMarco, x => x.MapFrom(y => y.nme_marco));
        }
    }
}
