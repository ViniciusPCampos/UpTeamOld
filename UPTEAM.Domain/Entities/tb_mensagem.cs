namespace UPTEAM.Domain.Entities
{
    public class tb_mensagem
    {

        public int idt_mensagem { get; set; }

        public string txt_mensagem { get; set; }

        public int idt_equipe { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }
    }
}
