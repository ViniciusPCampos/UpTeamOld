using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public  class MarcoService : IMarcoService
    {
        private readonly MarcoRepository _repository;
        0
        public MarcoService(MarcoRepository repositorio)
        {
            _repository = repositorio;
        }

        public List<tb_marco> BuscarPorProjeto(tb_projeto projeto)
        {
            return _repository.BuscarPorProjeto(projeto.idt_projeto).ToList();
        }
    }
}
