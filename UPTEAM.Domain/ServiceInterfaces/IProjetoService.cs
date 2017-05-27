using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IProjetoService
    {
        tb_projeto CriarNovoProjeto(tb_projeto projeto);

        void AtualizarProjeto(tb_projeto projeto);

        List<tb_projeto> BuscarPorEquipe(int idEquipe);

        List<tb_projeto> BuscarPorNome(string nomeProjeto);

        //List<tb_projeto> BuscarPorEstado(int idEstado);

        void ExcluirProjeto(tb_projeto projeto);
    }
}

