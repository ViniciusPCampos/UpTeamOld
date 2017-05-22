using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class ProjetoRepository : RepositoryBase<tb_projeto>, IProjetoRepository
    {
        public IEnumerable<tb_projeto> GetProjectByTeam(int equipeId)
        {
            return Db.Set<tb_projeto>().Where(x => x.idt_equipe == equipeId);
        }
    }
}
