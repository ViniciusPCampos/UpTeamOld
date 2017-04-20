using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
