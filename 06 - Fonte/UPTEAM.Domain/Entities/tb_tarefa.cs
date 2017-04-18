namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_tarefa { get; set; }

        [Required]
        [StringLength(80)]
        public string nme_tarefa { get; set; }

        [Required]
        [StringLength(200)]
        public string dsc_tarefa { get; set; }

        public int fk_dificuldade { get; set; }

        public int fk_sprint { get; set; }

        public int fk_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime dta_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime dta_fim { get; set; }

        public int fk_prioridade { get; set; }

        public virtual tb_sprint tb_sprint { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_dificuldade tt_dificuldade { get; set; }

        public virtual tt_prioridade tt_prioridade { get; set; }
    }
}
