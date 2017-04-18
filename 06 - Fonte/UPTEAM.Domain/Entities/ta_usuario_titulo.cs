namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ta_usuario_titulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_usuario_titulo { get; set; }

        [Required]
        [StringLength(45)]
        public string ta_usuario_titulocol { get; set; }

        public int fk_usuario { get; set; }

        public int fk_titulo { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_titulo tt_titulo { get; set; }
    }
}
