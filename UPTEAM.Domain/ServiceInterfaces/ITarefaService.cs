using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface ITarefaService
    {
        tb_tarefa CriarNovaTarefa(tb_tarefa tarefa);

        List<tb_tarefa> BuscarTarefasPorNome(string nomeTarefa);

        List<tb_tarefa> BuscarTarefasPorProjeto(int idProjeto);

        List<tb_tarefa> BuscarTarefasPorUsuario(tb_usuario usuario);

        List<tb_tarefa> BuscarTarefasPorSprint(int  idSprint);

        tb_tarefa BuscarTarefa(int idTarefa);

        void AlterarTarefa(tb_tarefa tarefa);

        void DeletarTarefa(tb_tarefa tarefa);
    }
}
