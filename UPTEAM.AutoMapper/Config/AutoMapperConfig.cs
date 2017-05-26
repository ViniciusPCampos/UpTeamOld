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
                x.AddProfile<TbTarefaMappingProfile>(); 
                x.AddProfile<TarefaMappingProfile>();
                x.AddProfile<TbMarcoMappingProfile>();
                x.AddProfile<MarcoMappingProfile>();
                x.AddProfile<TbMensagemMappingProfile>();
                x.AddProfile<MensagemMappingProfile>(); 
                x.AddProfile<TbEquipeMappingProfile>();
            });

        }
    }
}
