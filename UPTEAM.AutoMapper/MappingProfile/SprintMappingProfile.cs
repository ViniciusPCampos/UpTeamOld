using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class SprintMappingProfile : Profile
    {
        public SprintMappingProfile()
        {

            CreateMap<SprintModel, tb_sprint>()
                .ForMember(x => x.idt_sprint, x => x.MapFrom(y => y.IdSprint))
                .ForMember(x => x.vlr_iteracao_sprint, x => x.MapFrom(y => y.ValorIteracao))
                .ForMember(x => x.dta_inicio, x => x.MapFrom(y => y.DataInicio))
                .ForMember(x => x.dta_termino, x => x.MapFrom(y => y.DataFim))
                .ForMember(x => x.idt_projeto, x => x.MapFrom(y => y.Projeto));
        }
    }
}
