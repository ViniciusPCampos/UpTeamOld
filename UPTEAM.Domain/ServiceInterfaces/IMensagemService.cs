using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IMensagemService
    {
        
        tb_mensagem EnviarMensagem(tb_mensagem mensagem);

        List<tb_mensagem> BuscarPorEquipe(int idtEquipe);

    }
}
