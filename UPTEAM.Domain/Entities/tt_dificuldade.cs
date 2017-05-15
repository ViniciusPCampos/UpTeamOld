namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public class tt_dificuldade
    {
        public tt_dificuldade()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        public int idt_dificuldade { get; set; }

        public string nme_dificuldade { get; set; }

        public string dsc_dificuldade { get; set; }

        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
