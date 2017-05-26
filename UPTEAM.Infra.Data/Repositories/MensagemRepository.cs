using System;
using System.Collections.Generic;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class MensagemRepository : RepositoryBase<tb_mensagem>, IMensagemRepository
    {
        public IEnumerable<tb_mensagem> BuscarPorUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
