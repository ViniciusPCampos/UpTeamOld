namespace UPTEAM.Domain.Entities
{
    using System;

    public class tb_tarefa
    {
        public int idt_tarefa { get; set; }

        public string nme_tarefa { get; set; }

        public string dsc_tarefa { get; set; }

        public int idt_dificuldade { get; set; }

        public int idt_sprint { get; set; }

        public int idt_usuario { get; set; }

        public DateTime dta_inicio { get; set; }

        public DateTime dta_fim { get; set; }

        public int idt_prioridade { get; set; }
        public int idt_estado_tarefa { get; set; }
        public int idt_tipo_tarefa { get; set; }

        public virtual tb_sprint tb_sprint { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_dificuldade tt_dificuldade { get; set; }

        public virtual tt_prioridade tt_prioridade { get; set; }
        public virtual tt_estado_tarefa tt_estado_tarefa { get; set; }
        public virtual tt_tipo_tarefa tt_tipo_tarefa { get; set; }
    }
}
