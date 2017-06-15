using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IEquipeService
    {
        void CriarNovaEquipe(tb_equipe equipe);
        void AtualizarEquipe(tb_equipe equipe);
        List<tb_equipe> BuscarEquipesPorUsuario(tb_usuario usuario);
        void ExcluirEquipe(tb_equipe equipe);
        ICollection<tb_equipe> BuscarEquipePorNome(string nome);
        ICollection<tb_usuario> BuscarUsuariosEquipe(int idEquipe);
    }
}
