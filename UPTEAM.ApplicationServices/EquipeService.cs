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
        private EquipeRepository _equipeRepository;
        public EquipeService(EquipeRepository repository)
        {
            _equipeRepository = repository;
        }
        public void AtualizarEquipe(tb_equipe equipe)
        {
            _equipeRepository.Update(equipe);
        }

        public ICollection<tb_equipe> BuscarEquipePorNome(string nome)
        {
            return _equipeRepository.BuscarEquipePorNome(nome).ToList();
        }

        public List<tb_equipe> BuscarEquipesPorUsuario(tb_usuario usuario)
        {
            return _equipeRepository.BuscarEquipePorUsuario(usuario.idt_usuario).ToList();
        }
        public void CriarNovaEquipe(tb_equipe equipe)
        {
            _equipeRepository.Add(equipe);
        }

        public void ExcluirEquipe(tb_equipe equipe)
        {
            _equipeRepository.Remove(equipe);
        }
    }
}
