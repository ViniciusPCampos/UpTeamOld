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
    public class ProjetoMappingProfile : Profile
    {
        public ProjetoMappingProfile()
        {
            CreateMap<ProjetoModel, tb_projeto>()
                .ForMember(x => x.idt_projeto, x=> x.MapFrom(y => y.IdProjeto))
                .ForMember(x => x.nme_projeto, x => x.MapFrom(y => y.NomeProjeto))
                .ForMember(x => x.dsc_projeto, x => x.MapFrom(y => y.DescricaoProjeto))
                .ForMember(x => x.dta_inicio, x => x.MapFrom(y => y.DataInicioProjeto))
                .ForMember(x => x.dta_termino, x => x.MapFrom(y => y.DataTerminoProjeto))
                .ForMember(x => x.idt_equipe, x => x.MapFrom(y => y.EquipeProjeto));
        }
    }
}
