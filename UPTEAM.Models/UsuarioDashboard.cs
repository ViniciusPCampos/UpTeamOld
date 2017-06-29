using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Models
{
    public class UsuarioDashboard
    {
        public tb_usuario Usuario { get; set; }
        public List<tb_tarefa> ListaTarefa { get; set; }
        public List<tb_projeto> ListaProjetos { get; set; }
        public List<tb_equipe> ListaEquipes { get; set; }
        public List<tt_conquista> ListaConquista { get; set; }
    }
}
