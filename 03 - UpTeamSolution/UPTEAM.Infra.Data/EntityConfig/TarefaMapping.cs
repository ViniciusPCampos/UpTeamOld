using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    class TarefaMapping : EntityTypeConfiguration<tb_tarefa>
    {
        public TarefaMapping()
        {
            HasKey(x => x.idt_tarefa);
            Property(x => x.nme_tarefa).IsRequired().HasMaxLength(80);
            Property(x => x.dsc_tarefa).IsRequired().HasMaxLength(200);
        }
    }
}
