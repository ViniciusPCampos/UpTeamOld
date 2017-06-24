using System;

namespace UPTEAM.Models
{
    public class MensagemModel
    {
        public string TextoMensagem { get; set; }
        public DateTime DataEnvio { get; set; }
        public string DataEnvioFmt { get { return DataEnvio.ToString("dd/MM/yyyy"); } }
        public int Equipe { get; set; }
        public int Usuario { get; set; }

    }
}
