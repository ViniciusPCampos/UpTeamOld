using UPTEAM.Domain.Entities;
using System.Collections.Generic;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IMarcoRepository : IRepositoryBase<tb_marco>
    {
        IEnumerable<tb_marco> BuscarPorProjeto(int idProjeto);
    }
}
