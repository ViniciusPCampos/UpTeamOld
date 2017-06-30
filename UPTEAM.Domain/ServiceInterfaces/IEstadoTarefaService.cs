using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IEstadoTarefaService
    {
        ICollection<tt_estado_tarefa> BuscarTudo();
    }
}
