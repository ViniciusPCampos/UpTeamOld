using AutoMapper;
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
                x.AddProfile<MarcoMappingProfile>();
                x.AddProfile<TbMarcoMappingProfile>();
            });

        }
    }
}
