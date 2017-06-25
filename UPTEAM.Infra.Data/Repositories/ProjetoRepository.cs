using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class ProjetoRepository : RepositoryBase<tb_projeto>, IProjetoRepository
    {
        public IEnumerable<tb_projeto> BuscarPorEquipe(int idEquipe)
        {
            return Db.Set<tb_projeto>().Where(x => x.idt_equipe == idEquipe);
        }

        //public IEnumerable<tb_projeto> BuscarPorEstado(int idEstado)
        //{
        //    return Db.Set<tb_projeto>().Where(x => x.)
        //}

        public IEnumerable<tb_projeto> BuscarPorNome(string nomeProjeto)
        {
            return Db.Set<tb_projeto>().Where(x => x.nme_projeto.Contains(nomeProjeto)).ToList();
        }

        public List<tb_projeto> BuscarPorUsuario(tb_usuario usuario)
        {
            return Db.Set<ta_usuario_equipe>().Include("tb_projeto").Include("tb_equipe.tb_projeto")
                .Where(x => x.idt_usuario == usuario.idt_usuario)
                .SelectMany(x => x.tb_equipe.tb_projeto).ToList();
        }

        public IEnumerable<tb_projeto> BuscarProjetosTarefasPorUsuario(int idUsuario)
        {
            return Db.Set<tb_projeto>()
                .Include(x => x.tb_sprint)
                .Include(x => x.tb_sprint.Select(y => y.tb_tarefa))
                .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_dificuldade)))
                .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_estado_tarefa)))
                .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_prioridade)))
                .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_tipo_tarefa)))
                .Where(x => x.tb_sprint.Any(y => y.tb_tarefa.Any(z => z.idt_usuario == idUsuario)))
                .ToList();
        }
    }
}
