using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class EquipeService : IEquipeService
    {
        private readonly EquipeRepository _equipeRepositorio;
        private readonly UsuarioEquipeRepository _usuarioEquipeRepository;
        public EquipeService(EquipeRepository repositorio, UsuarioEquipeRepository usuarioEquipeRepository)
        {
            _equipeRepositorio = repositorio;
            _usuarioEquipeRepository = usuarioEquipeRepository;
        }

        public tb_equipe CriarNovaEquipe(tb_equipe equipe)
        {
            return _equipeRepositorio.Add(equipe);
        }

        public void AtualizarEquipe(tb_equipe equipe)
        {
            _equipeRepositorio.Update(equipe);
        }

        public ICollection<tb_equipe> BuscarEquipePorNome(string nome)
        {
            return _equipeRepositorio.BuscarEquipePorNome(nome).ToList();
        }

        public void AdicionarUsuario(int idtUsuario, int idtEquipe)
        {
            _usuarioEquipeRepository.Add(new ta_usuario_equipe()
            {
                idt_equipe = idtEquipe,
                idt_usuario = idtUsuario
            });
        }

        public ICollection<tb_usuario> BuscarUsuariosEquipe(int idEquipe)
        {
            return _equipeRepositorio.BuscarUsuariosEquipe(idEquipe);
        }

        public void CriarNovaEquipe(tb_equipe equipe)
        {
            return _equipeRepositorio.GetById(idtEquipe);
        }

        public List<tb_equipe> BuscarPorUsuario(int idtUsuario)
        {
            return _equipeRepositorio.BuscarEquipePorUsuario(idtUsuario).ToList();
        }

        public void ExcluirEquipe(tb_equipe equipe)
        {
            _equipeRepositorio.Remove(equipe);
        }

    }
}
