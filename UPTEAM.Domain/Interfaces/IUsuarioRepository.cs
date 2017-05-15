using System;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.Interfaces
{
    public interface IUsuarioRepository:IRepositoryBase<tb_usuario>
    {
        tb_usuario Authenticate(string email, string password);
    }
}
