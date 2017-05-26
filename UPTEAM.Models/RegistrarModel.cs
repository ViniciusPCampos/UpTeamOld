using System.ComponentModel.DataAnnotations;

namespace UPTEAM.Models
{
    public class RegistrarModel
    {
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage ="A Confirmação da Senha é obrigatória")]
        [DataType(DataType.Password)]
        public string ConfirmacaoSenha { get; set; }
        [Required(ErrorMessage = "o E-mail é obrigatório.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Login é obrigatório.")]
        [MaxLength(80)]
        public string Login { get; set; }
        [DataType(DataType.PhoneNumber)]
        [MaxLength(16)]
        public string Telefone { get; set; }
    }
}
