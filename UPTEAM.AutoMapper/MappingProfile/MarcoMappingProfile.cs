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
                .ForMember(x => x.nme_marco, x => x.MapFrom(y => y.NomeMarco))
                .ForMember(x => x.dsc_marco, x => x.MapFrom(y => y.Descricao))
                .ForMember(x => x.dln_marco, x => x.MapFrom(y => y.Deadline))
                .ForMember(x => x.idt_projeto, x => x.MapFrom(y => y.Projeto));
        }
    }
}
