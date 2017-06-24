using System;

namespace UPTEAM.Models
{
    public class MarcoModel
    {
        public string NomeMarco { get; set; }
        public string Descricao { get; set; }
        public DateTime Deadline { get; set; }
        public string DeadlineFmt { get { return Deadline.ToString("dd/MM/yyyy"); } }
        public int Projeto { get; set; }
    }
}
