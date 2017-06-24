namespace UPTEAM.Domain.Entities
{
    using System;

    public class tb_mensagem
    {

        public int idt_mensagem { get; set; }

        public string txt_mensagem { get; set; }

        public DateTime dta_envio { get; set; }

        public int idt_equipe { get; set; }

        public int idt_usuario { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }
    }
}
