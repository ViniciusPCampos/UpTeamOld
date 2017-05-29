using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IMarcoService
    {
        tb_marco CriarNovaMarco(tb_marco marco);

        List<tb_marco> BuscarPorProjeto(int idProjeto);

        tb_marco BuscarMarco(int idMarco);

        void AlterarMarco(tb_marco marco);

        void DeletarMarco(tb_marco marco);

    }
}
