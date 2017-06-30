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
    public class EstadoTarefaService : IEstadoTarefaService
    {
        public IEstadoTarefaRepository EstadoTarefaRepository { get; set; }

        public EstadoTarefaService(IEstadoTarefaRepository estadoTarefaRepository)
        {
            EstadoTarefaRepository = estadoTarefaRepository;
        }
        public ICollection<tt_estado_tarefa> BuscarTudo()
        {
            return EstadoTarefaRepository.GetAll().ToList();
        }
    }
}
