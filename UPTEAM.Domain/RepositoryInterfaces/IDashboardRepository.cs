using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.DTO;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IDashboardRepository : IDisposable
    {
        DashboardDTO ObterDashboard(int idUsuario);
    }
}
