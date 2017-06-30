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

        public tb_projeto BuscarProjetoPorId(int idProjeto)
        {
            return Db.Set<tb_projeto>().Include(x => x.tb_sprint).Include(x => x.tb_sprint.Select(y => y.tb_tarefa)).FirstOrDefault(x => x.idt_projeto == idProjeto);
        }

        public IEnumerable<tb_projeto> BuscarProjetosTarefasPorUsuario(int idUsuario)
        {

            //return Db.Set<tb_projeto>()
            //    .Include(x => x.tb_sprint)
            //    .Include(x => x.tb_sprint.Select(y => y.tb_tarefa))
            //    .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_dificuldade)))
            //    .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_estado_tarefa)))
            //    .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_prioridade)))
            //    .Include(x => x.tb_sprint.Select(y => y.tb_tarefa.Select(z => z.tt_tipo_tarefa)))                               
            //    .ToList();
            var queryProjeto = $@"select distinct p.* 
                            from tb_projeto p join tb_sprint s on s.idt_projeto = p.idt_projeto
                            join tb_tarefa t on t.idt_sprint = s.idt_sprint
                            where idt_usuario = {idUsuario}";

            var projetos = Db.Database.SqlQuery<tb_projeto>(queryProjeto).ToList();

            projetos.ForEach(x => x.tb_sprint = Db.Database.SqlQuery<tb_sprint>($"select distinct s.* from tb_sprint s join tb_tarefa t on t.idt_sprint = s.idt_sprint where idt_usuario = {idUsuario} and idt_projeto = {x.idt_projeto}")
            .Select(y => y).ToList());

            projetos.ForEach(x => x.tb_sprint.ToList().ForEach(s => s.tb_tarefa = Db.Database.SqlQuery<tb_tarefa>($"select * from tb_tarefa where idt_usuario = {idUsuario} and idt_sprint = {s.idt_sprint}").Select(t => t).ToList()));

            projetos.ForEach(x => x.tb_sprint.ToList().ForEach(s => s.tb_tarefa.ToList()
            .ForEach(t => t.tt_dificuldade = Db.Database.SqlQuery<tt_dificuldade>($"select * from tt_dificuldade where idt_dificuldade = {t.idt_dificuldade}").FirstOrDefault())));
            projetos.ForEach(x => x.tb_sprint.ToList().ForEach(s => s.tb_tarefa.ToList()
            .ForEach(t => t.tt_estado_tarefa = Db.Database.SqlQuery<tt_estado_tarefa>($"select * from tt_estado_tarefa where idt_estado_tarefa = {t.idt_estado_tarefa}").FirstOrDefault())));
            projetos.ForEach(x => x.tb_sprint.ToList().ForEach(s => s.tb_tarefa.ToList()
            .ForEach(t => t.tt_estado_tarefa = Db.Database.SqlQuery<tt_estado_tarefa>($"select * from tt_estado_tarefa where idt_estado_tarefa = {t.idt_estado_tarefa}").FirstOrDefault())));
            projetos.ForEach(x => x.tb_sprint.ToList().ForEach(s => s.tb_tarefa.ToList()
            .ForEach(t => t.tt_prioridade = Db.Database.SqlQuery<tt_prioridade>($"select * from tt_prioridade where idt_prioridade = {t.idt_prioridade}").FirstOrDefault())));
            projetos.ForEach(x => x.tb_sprint.ToList().ForEach(s => s.tb_tarefa.ToList()
            .ForEach(t => t.tt_tipo_tarefa = Db.Database.SqlQuery<tt_tipo_tarefa>($"select * from tt_tipo_tarefa where idt_tipo_tarefa = {t.idt_tipo_tarefa}").FirstOrDefault())));

            return projetos;

        }
    }
}
