namespace UPTEAM.Domain.Entities
{
    using System;

    public class tb_marco
    {
        public int idt_marco { get; set; }
        
        public string nme_marco { get; set; }
        
        public string dsc_marco { get; set; }
        
        public DateTime dln_marco { get; set; }

        public int idt_projeto { get; set; }

        public virtual tb_projeto tb_projeto { get; set; }
    }
}
