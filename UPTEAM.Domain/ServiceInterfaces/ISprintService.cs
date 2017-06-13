using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface ISprintService
    {
        tb_sprint CriarSprint(tb_sprint sprint);
        void AtualizarSprint(tb_sprint sprint);
        List<tb_sprint> BuscarPorProjeto(int idProjeto);
        void ExcluirSprint(tb_sprint sprint);
    }
}
