using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.ServiceInterfaces
{
    public interface IUsuarioService
    {
        tb_usuario Authenticate(string login, string password);
        tb_usuario ObterUsuarioPorLogin(string login);
        tb_usuario Register(tb_usuario usuario);
    }
}
