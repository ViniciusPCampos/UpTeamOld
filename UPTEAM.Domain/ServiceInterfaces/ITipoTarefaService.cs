using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    interface ITipoTarefaService
    {
        tt_tipo_tarefa BuscarPorId(int idtTipoTarefa);
    }
}
