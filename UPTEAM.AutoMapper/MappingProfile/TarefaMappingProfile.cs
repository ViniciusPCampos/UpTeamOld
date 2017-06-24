using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class TarefaMappingProfile : Profile
    {
        public TarefaMappingProfile()
        {
            CreateMap<TarefaModel, tb_tarefa>()
              .ForMember(x => x.nme_tarefa, x => x.MapFrom(y => y.NomeTarefa))
              .ForMember(x => x.dsc_tarefa, x => x.MapFrom(y => y.Descricao))
              .ForMember(x => x.dta_inicio, x => x.MapFrom(y => y.DataInicio))
              .ForMember(x => x.dta_fim, x => x.MapFrom(y => y.DataFim))
              .ForMember(x => x.idt_dificuldade, x => x.MapFrom(y => y.Dificuldade))
              .ForMember(x => x.idt_sprint, x => x.MapFrom(y => y.Sprint))
              .ForMember(x => x.idt_usuario, x => x.MapFrom (y => y.Usuario))
              .ForMember(x => x.idt_prioridade, x => x.MapFrom(y => y.Prioridade))
              .ForMember(x => x.idt_estado_tarefa, x => x.MapFrom(y => y.EstadoTarefa))
              .ForMember(x => x.idt_tipo_tarefa, x => x.MapFrom(y => y.TipoTarefa));
        }
    }
}
