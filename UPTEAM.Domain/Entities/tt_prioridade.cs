namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public class tt_prioridade
    {
        public tt_prioridade()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        public int idt_prioridade { get; set; }

        public string nme_prioridade { get; set; }
        public double mtp_exp_prioridade { get; set; }

        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
