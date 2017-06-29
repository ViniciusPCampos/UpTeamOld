using System;
using System.Collections.Generic;

namespace UPTEAM.Models
{
    public class ProjetoModel
    {
        public int IdProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public string DescricaoProjeto { get; set; }
        public DateTime DataInicioProjeto { get; set; }
        public DateTime DataTerminoProjeto { get; set; }
        public int EquipeProjeto { get; set; }
        public ICollection<SprintModel> Sprints { get; set; }
        public ICollection<MarcoModel> Marcos { get; set; }
    }
}
