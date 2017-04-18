namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_marco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_marco { get; set; }

        [Required]
        [StringLength(45)]
        public string nme_marco { get; set; }

        [Required]
        [StringLength(200)]
        public string dsc_marco { get; set; }

        [Column(TypeName = "date")]
        public DateTime dln_marco { get; set; }

        public int fk_projeto { get; set; }

        public virtual tb_projeto tb_projeto { get; set; }
    }
}
