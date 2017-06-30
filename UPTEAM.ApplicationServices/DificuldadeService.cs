using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.ApplicationServices
{
    public class DificuldadeService : IDificuldadeService
    {
        public IDificuldadeRepository DificuldadeRepository { get; set; }

        public DificuldadeService(IDificuldadeRepository dificuldadeRepository)
        {
            DificuldadeRepository = dificuldadeRepository;
        }
         public ICollection<tt_dificuldade> BuscarTudo()
         {
             return DificuldadeRepository.GetAll().ToList();
         }
    }
}
