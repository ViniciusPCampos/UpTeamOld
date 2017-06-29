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
                x.AddProfile<ProjetoMappingProfile>();
                x.AddProfile<TbProjetoMappingProfile>();
                x.AddProfile<SprintMappingProfile>();
                x.AddProfile<TbSprintMappingProfile>();
                x.AddProfile<TbTipoTarefaMappingProfile>();
                x.AddProfile<TbPrioridadeMappingProfile>();
                x.AddProfile<TbEstadoTarefaMappingProfile>();
                x.AddProfile<TbDificuldadeMappingProfile>();
            });

        }
    }
}
