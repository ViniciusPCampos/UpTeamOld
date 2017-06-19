using System;

namespace UPTEAM.Models
{
    public class ProjetoModel
    {
        public int ID { get; set; }
        public string NomeProjeto { get; set; }
        public string DescricaoProjeto { get; set; }
        public DateTime DataInicioProjeto { get; set; }
        public DateTime DataTerminoProjeto { get; set; }
        public int EquipeProjeto { get; set; }
    }
}
