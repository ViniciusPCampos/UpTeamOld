namespace UPTEAM.Domain.Entities
{
    public class ta_usuario_titulo
    {
        public int idt_usuario_titulo { get; set; }
        
        public string ta_usuario_titulocol { get; set; }

        public int fk_usuario { get; set; }

        public int fk_titulo { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tt_titulo tt_titulo { get; set; }
    }
}
