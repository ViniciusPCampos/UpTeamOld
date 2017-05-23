using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IProjetoRepository : IRepositoryBase<tb_projeto>
    {
        IEnumerable<tb_projeto> GetProjectByTeam(int equipeId);
    }
}
