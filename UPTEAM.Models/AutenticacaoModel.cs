using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPTEAM.Models
{
    public class AutenticacaoModel
    {
        [Required(ErrorMessage = "O Login é obrigatório.")]
        [StringLength(60)]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória.")]
        [DataType(DataType.Password)]
        [StringLength(60)]
        public string Senha { get; set; }
    }
}
