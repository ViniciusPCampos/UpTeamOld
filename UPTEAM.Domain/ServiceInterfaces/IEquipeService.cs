using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IEquipeService
    {
        tb_equipe CriarNovaEquipe(tb_equipe equipe);
        void AtualizarEquipe(tb_equipe equipe);
        List<tb_equipe> BuscarPorUsuario(int idtUsuario);
        void ExcluirEquipe(tb_equipe equipe);
        ICollection<tb_equipe> BuscarEquipePorNome(string nome);
        void AdicionarUsuario(int idtUsuario, int idtEquipe);
        tb_equipe BuscarPorId(int idtEquipe);
        ICollection<tb_usuario> BuscarUsuariosEquipe(int idEquipe);
        void AdicionarUsuario(int idtUsuario, int idtEquipe);
        tb_equipe BuscarPorId(int idtEquipe);
    }
}
