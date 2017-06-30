using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    interface IEstadoTarefaService
    {
        tt_estado_tarefa BuscarPorId(int idtEstadoTarefa);
    }
}
