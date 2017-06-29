using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class MensagemRepository : RepositoryBase<tb_mensagem>, IMensagemRepository
    {
        public IEnumerable<tb_mensagem> BuscarPorEquipe(int idEquipe)
        {
            return Db.Set<tb_mensagem>().Include("TB_USUARIO").Where(x => x.idt_equipe == idEquipe);
        }
    }
}
