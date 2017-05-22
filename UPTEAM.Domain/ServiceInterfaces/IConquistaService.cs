using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    interface IConquistaService
    {
        List<tt_conquista> BuscarConquistas();
    }
}
