using System.ComponentModel.DataAnnotations;

namespace UPTEAM.Models
{
    public class EquipeModel
    {
        [Required]
        public string NomeEquipe { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
