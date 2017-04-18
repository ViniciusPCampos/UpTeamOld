namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ta_usuario_equipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_usuario_equipe { get; set; }

        public int fk_usuario { get; set; }

        public int fk_equipe { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }
    }
}
