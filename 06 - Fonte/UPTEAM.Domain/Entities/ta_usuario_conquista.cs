namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ta_usuario_conquista
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_usuario_conquista { get; set; }

        //[Column(TypeName = "date")]
        public DateTime dta_conquista { get; set; }

        public int fk_usuario { get; set; }

        public int fk_conquista { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_conquista tt_conquista { get; set; }
    }
}
