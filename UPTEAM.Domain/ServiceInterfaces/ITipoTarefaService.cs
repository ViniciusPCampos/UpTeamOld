using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface ITipoTarefaService
    {
        ICollection<tt_tipo_tarefa> BuscarTudo();
    }
}
