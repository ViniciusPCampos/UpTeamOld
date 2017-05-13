namespace UPTEAM.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    public class tb_sprint
    {
        public tb_sprint()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }
        public int idt_sprint { get; set; }

        public int vlr_iteracao_sprint { get; set; }

        public DateTime dta_inicio { get; set; }

        public DateTime dta_termino { get; set; }

        public int cod_projeto { get; set; }

        public virtual tb_projeto tb_projeto { get; set; }

        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
