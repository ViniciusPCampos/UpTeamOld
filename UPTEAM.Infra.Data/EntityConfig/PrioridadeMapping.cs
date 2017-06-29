using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class PrioridadeMapping : EntityTypeConfiguration<tt_prioridade>
    {
        public PrioridadeMapping()
        {
            HasKey(x => x.idt_prioridade);

            Property(x => x.nme_prioridade)
                .IsRequired()
                .HasMaxLength(45);

        }
    }
}
