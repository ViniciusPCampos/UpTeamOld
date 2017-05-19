using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface ISprintService
    {
        void CriarSprint(tb_sprint sprint);
        void AtualizarSprint(tb_sprint sprint);
        List<tb_sprint> BuscarSprintsPorProjeto(tb_projeto projeto);
        tb_sprint BuscarSprint(int sprintId);
        void InserirTarefa(tb_tarefa tarefa, tb_sprint sprint);
        void ExcluirSprint(tb_tarefa tarefa);
    }
}
