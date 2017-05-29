using System;

namespace UPTEAM.Models
{
    public class TarefaModel
    {
        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Dificuldade { get; set; }
        public int Sprint { get; set; }
        public int Usuario { get; set; }
        public int Prioridade { get; set; }
        public int EstadoTarefa { get; set; }
        public int TipoTarefa { get; set; }
    }
}
