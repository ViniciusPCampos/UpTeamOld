using System.Collections.Generic;

namespace UPTEAM.Domain.Entities
{
    public class tt_estado_tarefa
    {
        public tt_estado_tarefa()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        public int idt_estado_tarefa { get; set; }

        public string nme_estado_tarefa { get; set; }

        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
