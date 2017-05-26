using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IEquipeRepository : IRepositoryBase<tb_equipe>
    {
        IEnumerable<tb_equipe> BuscarEquipePorUsuario(int idt_usuario);
        IEnumerable<tb_equipe> BuscarEquipePorNome(string nome);
    }
}
