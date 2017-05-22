using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.AutoMapper.MappingProfile;

namespace UPTEAM.AutoMapper.Config
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<UsuarioMappingProfile>();
                x.AddProfile<TarefaMappingProfile>(); 
                x.AddProfile<TbTarefaMappingProfile>();
            });

        }
    }
}
