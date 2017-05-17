using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class MarcoMapping : EntityTypeConfiguration<tb_marco>
    {
        public MarcoMapping()
        {
            HasKey(x => x.idt_marco);

            Property(x => x.nme_marco)
                .IsRequired()
                .HasMaxLength(45);

            Property(x => x.dsc_marco)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
