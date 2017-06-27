using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.DTO;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Infra.Data.Context;

namespace UPTEAM.Infra.Data.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        protected UpTeamContext _context;
        public DashboardRepository(UpTeamContext context)
        {
            _context = context; 
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public DashboardDTO ObterDashboard(int idUsuario)
        {
            var query = $@"select 
                    (select Count(*) from tb_equipe e join ta_usuario_equipe a on a.idt_equipe = e.idt_equipe where idt_usuario = {idUsuario}) Equipes,
                    (select Count(*) from tb_projeto p join tb_equipe e on p.idt_equipe = e.idt_equipe
                    join ta_usuario_equipe a on a.idt_equipe = e.idt_equipe 
                    where idt_usuario = {idUsuario}) Projetos,
                    (select Count(*) from tb_tarefa where idt_usuario = {idUsuario}) Tarefas";

            return _context.Database.SqlQuery<DashboardDTO>(query).FirstOrDefault();
        }
    }
}
