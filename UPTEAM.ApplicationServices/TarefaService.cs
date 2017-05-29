using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class TarefaService : ITarefaService
    {
        private TarefaRepository _tarefaRepositorio;

        public TarefaService(TarefaRepository repositorio)
        {
            _tarefaRepositorio = repositorio;
        }

        public void AlterarTarefa(tb_tarefa tarefa)
        {
            _tarefaRepositorio.Update(tarefa);
        }

        public tb_tarefa BuscarTarefa(int idTarefa)
        {
            return _tarefaRepositorio.GetById(idTarefa);
        }

        public List<tb_tarefa> BuscarTarefasPorNome(string nomeTarefa)
        {
            return _tarefaRepositorio.GetByName(nomeTarefa).ToList();
        }

        public List<tb_tarefa> BuscarTarefasPorProjeto(int idProjeto)
        {
            return _tarefaRepositorio.GetByProject(idProjeto).ToList();
        }

        public List<tb_tarefa> BuscarTarefasPorSprint(tb_sprint sprint)
        {
            return _tarefaRepositorio.GetBySprint(sprint.idt_sprint).ToList();
        }

        public List<tb_tarefa> BuscarTarefasPorUsuario(tb_usuario usuario)
        {
            return _tarefaRepositorio.GetByOwner(usuario.idt_usuario).ToList();
        }

        public tb_tarefa CriarNovaTarefa(tb_tarefa tarefa)
        {
            try
            {
                _tarefaRepositorio.Add(tarefa);

                return tarefa;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public void DeletarTarefa(tb_tarefa tarefa)
        {
            _tarefaRepositorio.Remove(tarefa);
        }
    }
}
