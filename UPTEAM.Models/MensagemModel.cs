using System;

namespace UPTEAM.Models
{
    public class MensagemModel
    {
        public string TextoMensagem { get; set; }
        public DateTime DataEnvio { get; set; }
        public string DataEnvioFmt { get { return DataEnvio.ToString("dd/MM/yyyy HH:mm:ss"); } }
        public int Equipe { get; set; }
        public int? IdUsuario { get; set; }
        public UsuarioModel Usuario { get; set; }

    }
}
