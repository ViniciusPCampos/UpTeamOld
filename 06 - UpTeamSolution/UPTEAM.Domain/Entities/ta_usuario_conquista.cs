namespace UPTEAM.Domain.Entities
{
    using System;

    public class ta_usuario_conquista
    {
        public int idt_usuario_conquista { get; set; }
        
        public DateTime dta_conquista { get; set; }

        public int fk_usuario { get; set; }

        public int fk_conquista { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_conquista tt_conquista { get; set; }
    }
}
