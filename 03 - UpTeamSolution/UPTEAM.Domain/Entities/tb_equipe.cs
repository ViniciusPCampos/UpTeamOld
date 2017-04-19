namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public class tb_equipe
    {
        public tb_equipe()
        {
            ta_usuario_equipe = new HashSet<ta_usuario_equipe>();
            tb_mensagem = new HashSet<tb_mensagem>();
            tb_projeto = new HashSet<tb_projeto>();
        }

        public int idt_equipe { get; set; }

        public string nme_equipe { get; set; }

        public string dsc_equipe { get; set; }

        public virtual ICollection<ta_usuario_equipe> ta_usuario_equipe { get; set; }

        public virtual ICollection<tb_mensagem> tb_mensagem { get; set; }

        public virtual ICollection<tb_projeto> tb_projeto { get; set; }
    }
}
