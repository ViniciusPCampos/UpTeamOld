using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.DTO;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IDashboardService
    {
        DashboardDTO ObterDashboard(int idUsuario);
    }
}
