using System;

namespace UPTEAM.Models
{
    public class SprintModel
    {
        public int IdSprint { get; set; }
        public int ValorIteracao { get; set; }
        public DateTime DataInicio { get; set; }
        public string DataInicioFmt { get { return DataInicio.ToString("dd/MM/yyyy"); } }
        public DateTime DataFim { get; set; }
        public string DataFimFmt { get { return DataFim.ToString("dd/MM/yyyy"); } }
        public int Projeto { get; set; }
    }
}
