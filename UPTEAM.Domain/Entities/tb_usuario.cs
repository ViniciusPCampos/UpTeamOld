namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public class tb_usuario
    {
        public tb_usuario()
        {
            ta_usuario_conquista = new HashSet<ta_usuario_conquista>();
            ta_usuario_equipe = new HashSet<ta_usuario_equipe>();
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        public int idt_usuario { get; set; }

        public string nme_usuario { get; set; }

        public string tel_usuario { get; set; }

        public string lgn_usuario { get; set; }

        public string pwd_usuario { get; set; }

        public string email_usuario { get; set; }

        public virtual ICollection<ta_usuario_conquista> ta_usuario_conquista { get; set; }

        public virtual ICollection<ta_usuario_equipe> ta_usuario_equipe { get; set; }

        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
