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
    public class TbTipoTarefaMappingProfile : Profile
    {
        public TbTipoTarefaMappingProfile()
        {
            CreateMap<tt_tipo_tarefa,TipoTarefaModel>()
                .ForMember(x => x.IdTipoTarefa, x => x.MapFrom(y => y.idt_tipo_tarefa))
                .ForMember(x => x.NomeTipoTarefa, x => x.MapFrom(y => y.nme_tipo_tarefa));
        }
    }
}
