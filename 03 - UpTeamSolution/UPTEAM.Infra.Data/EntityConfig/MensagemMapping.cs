using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    class MensagemMapping : EntityTypeConfiguration<tb_mensagem>
    {
        public MensagemMapping()
        {
            HasKey(x => x.idt_mensagem);
        }
    }
}
