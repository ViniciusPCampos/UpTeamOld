using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.Interfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<tb_usuario>, IUsuarioRepository
    {
        public tb_usuario Authenticate(string login, string password)
        {
            return Db.tb_usuario.Where(x => x.lgn_usuario.ToLower() == login.ToLower() && x.pwd_usuario == password).FirstOrDefault();
        }
    }
}
