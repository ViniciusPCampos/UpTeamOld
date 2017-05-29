using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IProjetoRepository : IRepositoryBase<tb_projeto>
    {
        IEnumerable<tb_projeto> BuscarPorEquipe(int idEquipe);
        IEnumerable<tb_projeto> BuscarPorNome(string nomeProjeto);
        //IEnumerable<tb_projeto> BuscarPorEstado(int idEstado);
    }
}
