using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTeam.Domain.Entities
{
    class Marco
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Deadline { get; set; }
        public Projeto Projeto { get; set; }
    }
}
