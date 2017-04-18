namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_mensagem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_mensagem { get; set; }

        [Required]
        [StringLength(45)]
        public string txt_mensagem { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fk_equipe { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }
    }
}
