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
    public class TbDificuldadeMappingProfile : Profile
    {
        public TbDificuldadeMappingProfile()
        {
            CreateMap<tt_dificuldade, DificuldadeModel>()
                    .ForMember(x => x.IdDificuldade, x => x.MapFrom(y => y.idt_dificuldade))
                    .ForMember(x => x.NomeDificuldade, x => x.MapFrom(y => y.nme_dificuldade))
                    .ForMember(x => x.Descricao, x => x.MapFrom(y => y.dsc_dificuldade))
                    .ForMember(x => x.Multiplicador, x => x.MapFrom(y => y.mtp_exp_dificuldade));
        }
    }
}
