using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class SprintService : ISprintService
    {
        private SprintRepository _sprintRepository;

        public SprintService(SprintRepository repository)
        {
            _sprintRepository = repository;
        }

        public void AtualizarSprint(tb_sprint sprint)
        {
            _sprintRepository.Update(sprint);
        }

        public List<tb_sprint> BuscarSprintPorProjeto(int projectId)
        {
            return _sprintRepository.GetSprintsByProject(projectId).ToList();
        }

        public void CriarSprint(tb_sprint sprint)
        {
            _sprintRepository.Add(sprint);
        }

        public void ExcluirSprint(tb_sprint sprint)
        {
            _sprintRepository.Remove(sprint);
        }
    }
}
