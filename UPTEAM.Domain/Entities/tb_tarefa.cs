namespace UPTEAM.Domain.Entities
{
    using System;

    public class tb_tarefa
    {
        public int idt_tarefa { get; set; }

        public string nme_tarefa { get; set; }

        public string dsc_tarefa { get; set; }

        public int cod_dificuldade { get; set; }

        public int cod_sprint { get; set; }

        public int cod_usuario { get; set; }

        public DateTime dta_inicio { get; set; }

        public DateTime dta_fim { get; set; }

        public int cod_prioridade { get; set; }
        public int cod_estado_tarefa { get; set; }
        public int cod_tipo_tarefa { get; set; }

        public virtual tb_sprint tb_sprint { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_dificuldade tt_dificuldade { get; set; }

        public virtual tt_prioridade tt_prioridade { get; set; }
        public virtual tt_estado_tarefa tt_estado_tarefa { get; set; }
        public virtual tt_tipo_tarefa tt_tipo_tarefa { get; set; }
    }
}
