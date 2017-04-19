using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class UsuarioConquistaMapping : EntityTypeConfiguration<ta_usuario_conquista>
    {
        public UsuarioConquistaMapping()
        {
            HasKey(x => x.idt_usuario_conquista);
        }
    }
}
