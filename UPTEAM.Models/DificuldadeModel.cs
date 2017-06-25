using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPTEAM.Models
{
    public class DificuldadeModel
    {
        public int IdDificuldade { get; set; }
        public string NomeDificuldade { get; set; }
        public string Descricao { get; set; }
        public double Multiplicador { get; set; }
    }
}
