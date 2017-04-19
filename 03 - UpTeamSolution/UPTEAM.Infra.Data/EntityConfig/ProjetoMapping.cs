using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class ProjetoMapping : EntityTypeConfiguration<tb_projeto>
    {
        public ProjetoMapping()
        {
            HasKey(x => x.idt_projeto);

            Property(x => x.nme_projeto).HasMaxLength(80).IsRequired();

            Property(x => x.dsc_projeto).HasMaxLength(200).IsRequired();
        }
    }
}
