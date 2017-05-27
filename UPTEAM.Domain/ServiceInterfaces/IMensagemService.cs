using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IMensagemService
    {
        //Famoso Cadastrar mensagem, apenas adequar o nome para o que a ação representa de fato
        tb_mensagem EnviarMensagem(tb_mensagem mensagem);

        List<tb_mensagem> BuscarPorEquipe(int idtEquipe);

    }
}
