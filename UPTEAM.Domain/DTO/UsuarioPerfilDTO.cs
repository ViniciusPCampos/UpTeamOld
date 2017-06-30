using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPTEAM.Domain.DTO
{
    public class UsuarioPerfilDTO
    {
        public UsuarioPerfilDTO(string nomeUsuario, string login)
        {
            NomeUsuario = nomeUsuario;
            Login = login;
        }
        public string NomeUsuario { get; set; }
        public string Login { get; set; }
        public string Nivel { get; set; }
        public double Experiencia { get; set; }
        public double ExpProximoNivel { get; set; }
        public string ProximoNivelPorcento { get { return ExpProximoNivel > 0 ? (Experiencia / ExpProximoNivel).ToString("P").Replace(',','.') : "0"; } }
    }
}
