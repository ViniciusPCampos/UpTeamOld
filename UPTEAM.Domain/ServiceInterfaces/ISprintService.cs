using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface ISprintService
    {
        void CriarSprint(tb_sprint sprint);
        void AtualizarSprint(tb_sprint sprint);
        List<tb_sprint> BuscarSprintPorProjeto(int projectId);
        void ExcluirSprint(tb_sprint sprint);
    }
}
