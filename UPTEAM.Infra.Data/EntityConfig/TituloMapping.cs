using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data
{
    public class TituloMapping : EntityTypeConfiguration<tt_titulo>
    {
        public TituloMapping()
        {
            HasKey(x => x.idt_titulo);

            Property(x => x.nme_titulo)
                .IsRequired()
                .HasMaxLength(45);

            Property(x => x.dsc_titulo)
                .IsRequired()
                .HasMaxLength(45);
        }
    }
}
