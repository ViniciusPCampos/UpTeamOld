using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.ApplicationServices
{
    public class PrioridadeService : IPrioridadeService
    {
        public IPrioridadeRepository PrioridadeRepository { get; set; }

        public PrioridadeService(IPrioridadeRepository prioridadeRepository)
        {
            PrioridadeRepository = prioridadeRepository;
        }
        public ICollection<tt_prioridade> BuscarTudo()
        {
            return PrioridadeRepository.GetAll().ToList();
        }
    }
}
