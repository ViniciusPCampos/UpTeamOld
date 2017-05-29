using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class TbMarcoMappingProfile : Profile
    {
        public TbMarcoMappingProfile()
        {
            CreateMap<tb_marco, MarcoModel>()
                .ForMember(x => x.NomeMarco, x => x.MapFrom(y => y.nme_marco))
                .ForMember(x => x.Descricao, x => x.MapFrom(y => y.dsc_marco))
                .ForMember(x => x.Deadline, x => x.MapFrom(y => y.dln_marco))
                .ForMember(x => x.Projeto, x => x.MapFrom(y => y.idt_projeto));
        }
    }
}
