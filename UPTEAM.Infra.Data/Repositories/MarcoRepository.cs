
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class MarcoRepository : RepositoryBase<tb_marco>, IMarcoRepository
    {
        public IEnumerable<tb_marco> BuscarPorProjeto(int idProjeto)
        {
            return Db.Set<tb_marco>().Where(x => x.idt_projeto == idProjeto);
        }
    }
}
