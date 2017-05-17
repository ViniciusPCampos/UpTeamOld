using System;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface IUsuarioRepository:IRepositoryBase<tb_usuario>
    {
        tb_usuario Authenticate(string login);
        bool Register(tb_usuario usuario);
    }
}
