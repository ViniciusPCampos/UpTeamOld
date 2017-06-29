using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class NivelMapping : EntityTypeConfiguration<tt_nivel>
    {
        public NivelMapping()
        {
            HasKey(x => x.idt_nivel);

            Property(x => x.nme_nivel)
                .IsRequired();

            Property(x => x.vlr_exp_max)
                .IsRequired();
        }
    }
}
