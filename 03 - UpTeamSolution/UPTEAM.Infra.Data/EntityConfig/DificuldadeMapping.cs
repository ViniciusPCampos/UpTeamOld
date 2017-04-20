using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class DificuldadeMapping : EntityTypeConfiguration<tt_dificuldade>
    {
        public DificuldadeMapping()
        {
            HasKey(x => x.idt_dificuldade);

            Property(x => x.nme_dificuldade)
                .IsRequired()
                .HasMaxLength(80);

            Property(x => x.dsc_dificuldade)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
