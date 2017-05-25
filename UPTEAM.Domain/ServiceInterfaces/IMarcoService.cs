using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    interface IMarcoService
    {
        void CriarNovoMarco(tb_marco marco);

        List<tb_marco> BuscarPorProjeto(int projetoId);

        void AtualizarMarco(tb_marco marco);

        void DeletarMarco(tb_marco marco);
    }
}
