namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public class tt_nivel
    {
        public tt_nivel()
        {
            tb_usuario = new HashSet<tb_usuario>();
        }

        public int idt_nivel { get; set; }

        public int des_nivel { get; set; }

        public int vlr_exp_max { get; set; }

        public virtual ICollection<tb_usuario> tb_usuario { get; set; }
    }
}
