using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.DTO;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class DashboardService : IDashboardService
    {
        private readonly DashboardRepository _dashboardRepositorio;
        public DashboardService(DashboardRepository dashboardRepositorio)
        {
            _dashboardRepositorio = dashboardRepositorio;
        }
        public DashboardDTO ObterDashboard(int idUsuario)
        {
            return _dashboardRepositorio.ObterDashboard(idUsuario);
        }
    }
}
