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
    public class TbEstadoTarefaMappingProfile : Profile
    {
        public TbEstadoTarefaMappingProfile()
        {
            CreateMap<tt_estado_tarefa, EstadoTarefaModel>()
                .ForMember(x => x.IdEstadoTarefa, x => x.MapFrom(y => y.idt_estado_tarefa))
                .ForMember(x => x.NomeEstadoTarefa, x => x.MapFrom(y => y.nme_estado_tarefa));
        }
    }
}
