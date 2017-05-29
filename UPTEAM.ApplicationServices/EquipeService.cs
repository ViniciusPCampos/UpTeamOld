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
        private EquipeRepository _equipeRepositorio;
        public EquipeService(EquipeRepository repositorio)
        {
            _equipeRepositorio = repositorio;
        }
        public void AtualizarEquipe(tb_equipe equipe)
        {
            _equipeRepositorio.Update(equipe);
        }

        public ICollection<tb_equipe> BuscarEquipePorNome(string nome)
        {
            return _equipeRepositorio.BuscarEquipePorNome(nome).ToList();
        }

        public List<tb_equipe> BuscarEquipesPorUsuario(tb_usuario usuario)
        {
            return _equipeRepositorio.BuscarEquipePorUsuario(usuario.idt_usuario).ToList();
        }
        public void CriarNovaEquipe(tb_equipe equipe)
        {
            _equipeRepositorio.Add(equipe);
        }

        public void ExcluirEquipe(tb_equipe equipe)
        {
            _equipeRepositorio.Remove(equipe);
        }
    }
}
