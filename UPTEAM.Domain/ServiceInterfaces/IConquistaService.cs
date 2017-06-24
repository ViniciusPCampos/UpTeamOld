using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IConquistaService
    {
        List<tt_conquista> BuscarConquistas();
    }
}
