using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IMensagemRepository : IRepositoryBase<tb_mensagem>
    {
        IEnumerable<tb_mensagem> BuscarPorEquipe(int idEquipe);
    }
}
