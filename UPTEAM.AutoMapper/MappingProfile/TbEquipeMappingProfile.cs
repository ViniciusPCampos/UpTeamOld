using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.MappingProfile
{
    public class TbEquipeMappingProfile : Profile
    {
        public TbEquipeMappingProfile()
        {
            CreateMap<tb_equipe, EquipeModel>()
                .ForMember(x => x.IdEquipe, x => x.MapFrom(y => y.idt_equipe))
                .ForMember(x => x.NomeEquipe, x => x.MapFrom(y => y.nme_equipe))
                .ForMember(x => x.Descricao, x => x.MapFrom(y => y.dsc_equipe));
            CreateMap<EquipeModel, tb_equipe>()
                .ForMember(x => x.idt_equipe, x=> x.MapFrom(y => y.IdEquipe))
                .ForMember(x => x.dsc_equipe, x => x.MapFrom(y => y.Descricao))
                .ForMember(x => x.nme_equipe, x => x.MapFrom(y => y.NomeEquipe));
        }
    }
}
