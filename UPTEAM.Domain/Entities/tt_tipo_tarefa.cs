using System.Collections.Generic;

namespace UPTEAM.Domain.Entities
{
    public class tt_tipo_tarefa
    {
        public tt_tipo_tarefa()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        public int idt_tipo_tarefa { get; set; }

        public string nme_tipo_tarefa { get; set; }

        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
