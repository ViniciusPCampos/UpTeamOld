using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTeam.Domain.Entities
{
    class Tarefa
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Usuario Proprietario { get; set; }
        public Dificuldade Dificuldade { get; set; } 
        public Sprint Sprint { get; set; }
        public Prioridade Prioridade { get; set; }
    }
}
