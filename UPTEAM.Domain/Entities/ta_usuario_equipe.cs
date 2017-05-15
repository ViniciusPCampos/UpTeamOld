namespace UPTEAM.Domain.Entities
{
    public class ta_usuario_equipe
    {
        public int idt_usuario_equipe { get; set; }

        public int cod_usuario { get; set; }

        public int cod_equipe { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }
    }
}
