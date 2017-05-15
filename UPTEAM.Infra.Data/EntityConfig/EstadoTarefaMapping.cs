using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class EstadoTarefaMapping : EntityTypeConfiguration<tt_estado_tarefa>
    {
        public EstadoTarefaMapping()
        {
            HasKey(x => x.idt_estado_tarefa);
        }
    }
}
