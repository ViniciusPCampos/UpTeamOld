using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class TipoTarefaMapping : EntityTypeConfiguration<tt_tipo_tarefa>
    {
        public TipoTarefaMapping()
        {
            HasKey(x => x.idt_tipo_tarefa);
        }
    }
}
