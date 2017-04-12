using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTeam.Domain.Entities
{
    class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Experiencia { get; set; }
        public Nivel Nivel { get; set; }
    }
}
