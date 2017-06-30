using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    interface IPrioridadeService
    {
        tt_prioridade BuscarPorId(int idtPrioridade);
    }
}
