using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface ISprintService
    {
        void CriarSprint();
        void AtualizarSprint(tb_sprint sprint);
        List<tb_sprint> BuscarSprintPorProjeto();
        void ExcluirSprint(tb_sprint sprint);
    }
}
