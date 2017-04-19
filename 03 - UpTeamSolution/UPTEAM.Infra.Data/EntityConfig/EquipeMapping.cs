using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class EquipeMapping : EntityTypeConfiguration<tb_equipe>
    {
        public EquipeMapping()
        {
            HasKey(x => x.idt_equipe);

            Property(x => x.nme_equipe)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.dsc_equipe)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
