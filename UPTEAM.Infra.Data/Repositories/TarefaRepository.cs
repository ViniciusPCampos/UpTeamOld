using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class TarefaRepository : RepositoryBase<tb_tarefa>, ITarefaRepository
    {
        public IEnumerable<tb_tarefa> GetByName(string tarefaName)
        {
            return Db.Set<tb_tarefa>().Where(x => x.nme_tarefa.Contains(tarefaName)).ToList();
        }

        public IEnumerable<tb_tarefa> GetByOwner(int userId)
        {
            return Db.Set<tb_tarefa>()
                .Include(x => x.tt_dificuldade)
                .Include(x => x.tt_estado_tarefa)
                .Include(x => x.tt_prioridade)
                .Include(x => x.tt_tipo_tarefa)
                .Where(x => x.idt_usuario == userId);
        }

        public IEnumerable<tb_tarefa> GetByProject(int projectId)
        {
            return Db.tb_tarefa
                .Join(Db.tb_sprint, tarefa => tarefa.idt_sprint, sprint => sprint.idt_sprint, (tarefa, sprint) => new { tb_tarefa = tarefa, tb_sprint = sprint })
                .Where(tarefaSprint => tarefaSprint.tb_sprint.idt_projeto == projectId)
                .Select(tarefaSprint => tarefaSprint.tb_tarefa);
        }

        public IEnumerable<tb_tarefa> GetBySprint(int sprintId)
        {
            return Db.Set<tb_tarefa>()
                .Include(x => x.tt_dificuldade)
                .Include(x => x.tt_estado_tarefa)
                .Include(x => x.tt_prioridade)
                .Include(x => x.tt_tipo_tarefa)
                .Where(x => x.idt_sprint == sprintId);
        }
    }
}
