using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface ITarefaRepository : IRepositoryBase<tb_tarefa>
    {
        IEnumerable<tb_tarefa> GetByName(string tarefaName);
        IEnumerable<tb_tarefa> GetByProject(int projectId);
        IEnumerable<tb_tarefa> GetByOwner(int userId);
        IEnumerable<tb_tarefa> GetBySprint(int sprintId);
    }
}
