namespace UPTEAM.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class tb_projeto
    {
        public tb_projeto()
        {
            tb_marco = new HashSet<tb_marco>();
            tb_sprint = new HashSet<tb_sprint>();
        }

        public int idt_projeto { get; set; }

        public string nme_projeto { get; set; }

        public string dsc_projeto { get; set; }

        public DateTime dta_inicio { get; set; }

        public DateTime dta_termino { get; set; }

        public int fk_equipe { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }

        public virtual ICollection<tb_marco> tb_marco { get; set; }

        public virtual ICollection<tb_sprint> tb_sprint { get; set; }
    }
}
