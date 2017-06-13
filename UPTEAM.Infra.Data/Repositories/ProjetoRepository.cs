using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class ProjetoRepository : RepositoryBase<tb_projeto>, IProjetoRepository
    {
        public IEnumerable<tb_projeto> BuscarPorEquipe(int idEquipe)
        {
            return Db.Set<tb_projeto>().Where(x => x.idt_equipe == idEquipe);
        }

        //public IEnumerable<tb_projeto> BuscarPorEstado(int idEstado)
        //{
        //    return Db.Set<tb_projeto>().Where(x => x.)
        //}

        public IEnumerable<tb_projeto> BuscarPorNome(string nomeProjeto)
        {
            return Db.Set<tb_projeto>().Where(x => x.nme_projeto.Contains(nomeProjeto)).ToList();
        }

    }
}
