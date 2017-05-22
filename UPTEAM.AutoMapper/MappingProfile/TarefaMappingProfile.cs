﻿using AutoMapper;
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
            CreateMap<tb_tarefa, TarefaModel>()
              .ForMember(x => x.NomeTarefa, x => x.MapFrom(y => y.nme_tarefa))
              .ForMember(x => x.Descricao, x => x.MapFrom(y => y.dsc_tarefa))
              .ForMember(x => x.DataInicio, x => x.MapFrom(y => y.dta_inicio))
              .ForMember(x => x.DataFim, x => x.MapFrom(y => y.dta_fim))
              .ForMember(x => x.Dificuldade, x => x.MapFrom(y => y.idt_dificuldade))
              .ForMember(x => x.Sprint, x => x.MapFrom(y => y.idt_sprint))
              .ForMember(x => x.Usuario, x => x.MapFrom(y => y.idt_usuario))
              .ForMember(x => x.Prioridade, x => x.MapFrom(y => y.idt_prioridade))
              .ForMember(x => x.EstadoTarefa, x => x.MapFrom(y => y.idt_estado_tarefa))
              .ForMember(x => x.TipoTarefa, x => x.MapFrom(y => y.idt_tipo_tarefa)).ReverseMap();
        }
    }
}
