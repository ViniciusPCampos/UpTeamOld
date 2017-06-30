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
        private SprintRepository _sprintRepositorio;

        public SprintService(SprintRepository repositorio)
        {
            _sprintRepositorio = repositorio;
        }

        public void AtualizarSprint(tb_sprint sprint)
        {
            _sprintRepositorio.Update(sprint);
        }

        public tb_sprint BuscarPorId(int id)
        {
            return _sprintRepositorio.BuscarPorId(id);
        }

        public List<tb_sprint> BuscarPorProjeto(int idProjeto)
        {
            return _sprintRepositorio.BuscarPorProjeto(idProjeto).ToList();
        }

        public void ExcluirSprint(tb_sprint sprint)
        {
            _sprintRepositorio.Remove(sprint);
        }

        tb_sprint ISprintService.CriarSprint(tb_sprint sprint)
        {
            try
            {
                _sprintRepositorio.Add(sprint);

                return sprint;
            }
            catch(System.Exception)
            {
                return null;
            }
        }
    }
}
