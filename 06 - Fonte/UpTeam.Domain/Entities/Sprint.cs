using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTeam.Domain.Entities
{
    class Sprint
    {
        public int Iteracao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Projeto Projeto { get; set; }
    }
}
