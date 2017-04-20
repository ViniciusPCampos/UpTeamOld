namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_titulo
    {
        public tt_titulo()
        {
            ta_usuario_titulo = new HashSet<ta_usuario_titulo>();
        }

        public int idt_titulo { get; set; }

        public string nme_titulo { get; set; }

        public string dsc_titulo { get; set; }

        public virtual ICollection<ta_usuario_titulo> ta_usuario_titulo { get; set; }
    }
}
