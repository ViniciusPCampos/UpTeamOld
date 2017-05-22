using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IMarcoService
    {
        List<tb_marco> BuscarPorProjeto(tb_projeto projeto);
    }
}
