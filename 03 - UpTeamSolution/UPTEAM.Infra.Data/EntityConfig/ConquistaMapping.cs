using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class ConquistaMapping : EntityTypeConfiguration<tt_conquista>
    {
        public ConquistaMapping()
        {
            HasKey(x => x.idt_conquista);

            Property(x => x.nme_conquista)
                .IsRequired()
                .HasMaxLength(80);

            Property(x => x.dsc_conquista)
                .IsRequired()
                .HasMaxLength(45);
        }
    }
}
