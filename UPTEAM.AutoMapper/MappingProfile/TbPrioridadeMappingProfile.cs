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
    public class TbPrioridadeMappingProfile : Profile
    {
        public TbPrioridadeMappingProfile()
        {
            CreateMap<tt_prioridade, PrioridadeModel>()
                .ForMember(x => x.IdPrioridade, x => x.MapFrom(y => y.idt_prioridade))
                .ForMember(x => x.NomePrioridade, x => x.MapFrom(y => y.nme_prioridade))
                .ForMember(x => x.Multiplicador, x => x.MapFrom(y => y.mtp_exp_prioridade));
        }
    }
}
