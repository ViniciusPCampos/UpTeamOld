using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.ApplicationServices
{
    public class TipoTarefaService : ITipoTarefaService
    {
        public ITipoTarefaRepository TipoTarefaRepository { get; set; }

        public TipoTarefaService(ITipoTarefaRepository tipoTarefaRepository)
        {
            TipoTarefaRepository = tipoTarefaRepository;
        }
        public ICollection<tt_tipo_tarefa> BuscarTudo()
        {
            return TipoTarefaRepository.GetAll().ToList();
        }
    }
}
