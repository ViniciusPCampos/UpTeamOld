using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IProjetoService
    {
        void CriarNovoProjeto(tb_projeto projeto);
        void AtualizarProjeto(tb_projeto projeto);
        List<tb_projeto> BuscarProjetosPorEquipe(tb_equipe equipe);
        void ExcluirProjeto(tb_projeto projeto);
    }
}
