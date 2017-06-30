using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
        public tb_sprint BuscarPorId(int idSprint)
        {
            return Db.Set<tb_sprint>()
                .Include(x => x.tb_tarefa)
                .Include(x => x.tb_tarefa.Select(y => y.tt_dificuldade))
                .Include(x => x.tb_tarefa.Select(y => y.tt_estado_tarefa))
                .Include(x => x.tb_tarefa.Select(y => y.tt_prioridade))
                .Include(x => x.tb_tarefa.Select(y => y.tt_tipo_tarefa))
                .FirstOrDefault(x => x.idt_sprint == idSprint);
        }
    }
}
