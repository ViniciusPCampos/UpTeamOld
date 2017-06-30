using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IDificuldadeService
    {
        ICollection<tt_dificuldade> BuscarTudo();
    }
}
