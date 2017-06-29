using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class UsuarioMapping :EntityTypeConfiguration<tb_usuario>
    {
        public UsuarioMapping()
        {
            HasKey(x => x.idt_usuario);
            Property(x => x.nme_usuario)
                .IsRequired()
                .HasMaxLength(80);

            Property(x => x.tel_usuario)
                .HasMaxLength(16);

            Property(x => x.lgn_usuario)
                .IsRequired()
                .HasMaxLength(20);

            Property(x => x.pwd_usuario)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
