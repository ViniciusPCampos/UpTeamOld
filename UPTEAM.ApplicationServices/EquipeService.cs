using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class EquipeService : IEquipeService
    {
        private EquipeRepository _equipeRepostiory;
        public EquipeService(EquipeRepository repository)
        {
            _equipeRepostiory = repository;
        }
        public void AtualizarEquipe(tb_equipe equipe)
        {
            _equipeRepostiory.Update(equipe);
        }

        public List<tb_equipe> BuscarEquipesPorUsuario(tb_usuario usuario)
        {
            return _equipeRepostiory.GetTeamsByUser(usuario.idt_usuario).ToList();
        }
        public void CriarNovaEquipe(tb_equipe equipe)
        {
            _equipeRepostiory.Add(equipe);
        }

        public void ExcluirEquipe(tb_equipe equipe)
        {
            _equipeRepostiory.Remove(equipe);
        }
    }
}
