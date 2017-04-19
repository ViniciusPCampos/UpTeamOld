namespace UPTEAM.Domain.Entities
{
    using System;

    public partial class tb_tarefa
    {
        public int idt_tarefa { get; set; }

        public string nme_tarefa { get; set; }

        public string dsc_tarefa { get; set; }

        public int fk_dificuldade { get; set; }

        public int fk_sprint { get; set; }

        public int fk_usuario { get; set; }

        public DateTime dta_inicio { get; set; }

        public DateTime dta_fim { get; set; }

        public int fk_prioridade { get; set; }

        public virtual tb_sprint tb_sprint { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_dificuldade tt_dificuldade { get; set; }

        public virtual tt_prioridade tt_prioridade { get; set; }
    }
}
