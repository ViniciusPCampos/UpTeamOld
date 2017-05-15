using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class UsuarioTituloMapping : EntityTypeConfiguration<ta_usuario_titulo>
    {
        public UsuarioTituloMapping()
        {
            HasKey(x => x.idt_usuario_titulo);

        }
    }
}
