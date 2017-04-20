namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_conquista
    {
        public tt_conquista()
        {
            ta_usuario_conquista = new HashSet<ta_usuario_conquista>();
        }

        public int idt_conquista { get; set; }

        public string nme_conquista { get; set; }

        public string dsc_conquista { get; set; }

        public virtual ICollection<ta_usuario_conquista> ta_usuario_conquista { get; set; }
    }
}
