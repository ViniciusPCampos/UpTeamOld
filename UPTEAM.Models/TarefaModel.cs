using System;

namespace UPTEAM.Models
{
    public class TarefaModel
    {
        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public string DataInicioFmt { get { return DataInicio.ToString("dd/MM/yyyy"); } }
        public DateTime DataFim { get; set; }
        public string DataFimFmt { get { return DataFim.ToString("dd/MM/yyyy"); } }
        public int IdDificuldade { get; set; }
        public DificuldadeModel Dificuldade { get; set; }
        public int Sprint { get; set; }
        public int Usuario { get; set; }
        public int IdPrioridade { get; set; }
        public PrioridadeModel Prioridade { get; set; }
        public int IdEstadoTarefa { get; set; }
        public EstadoTarefaModel EstadoTarefa { get; set; }
        public int IdTipoTarefa { get; set; }
        public TipoTarefaModel TipoTarefa { get; set; }
    }
}
