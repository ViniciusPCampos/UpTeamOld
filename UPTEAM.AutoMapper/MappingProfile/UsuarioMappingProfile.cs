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
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<tb_usuario, UsuarioModel>()
              .ForMember(x => x.Nome, x => x.MapFrom(y => y.nme_usuario))
              .ForMember(x => x.Telefone, x => x.MapFrom(y => y.tel_usuario))
              .ForMember(x => x.Login, x => x.MapFrom(y => y.lgn_usuario)).ReverseMap();
        }
    }
}
