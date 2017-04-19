using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class UsuarioEquipeMapping : EntityTypeConfiguration<ta_usuario_equipe>
    {
        public UsuarioEquipeMapping()
        {
            HasKey(x => x.idt_usuario_equipe);
        }
    }
}
