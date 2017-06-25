using AutoMapper;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class TbSprintMappingProfile : Profile
    {
        public TbSprintMappingProfile()
        {
            CreateMap<tb_sprint, SprintModel>()
                .ForMember(x => x.IdSprint, x => x.MapFrom(y => y.idt_sprint))
                .ForMember(x => x.ValorIteracao, x => x.MapFrom(y => y.vlr_iteracao_sprint))
                .ForMember(x => x.DataInicio, x => x.MapFrom(y => y.dta_inicio))
                .ForMember(x => x.DataFim, x => x.MapFrom(y => y.dta_termino))
                .ForMember(x => x.Projeto, x => x.MapFrom(y => y.idt_projeto))
                .ForMember(x => x.Tarefas, x => x.MapFrom(y => y.tb_tarefa));
        }
    }
}
