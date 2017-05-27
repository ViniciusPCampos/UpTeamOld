using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class SprintRepository : RepositoryBase<tb_sprint>, ISprintRepository
    {
        public IEnumerable<tb_sprint> BuscarPorProjeto(int idProjeto)
        {
            return Db.Set<tb_sprint>().Where(x => x.idt_projeto == idProjeto);
        }
    }
}
