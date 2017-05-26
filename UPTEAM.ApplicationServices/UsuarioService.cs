using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.ApplicationServices.Helpers.Criptography;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _repository;
        private ICryptographyHelper _cript;
        public UsuarioService(IUsuarioRepository repository, ICryptographyHelper cript)
        {
            _repository = repository;
            _cript = cript;
        }
        public tb_usuario Authenticate(string login, string password)
        {
            var user = _repository.Authenticate(login);


            if (user != null)
            {
                if (_cript.ValidatePassword(password, user.pwd_usuario))
                    return user;
            }


            return null;
        }

        public tb_usuario Register(tb_usuario usuario)
        {
            var password = _cript.CreateHash(usuario.pwd_usuario);
            usuario.pwd_usuario = password;
            usuario.idt_nivel = 1;
            usuario.exp_usuario = 0;

            if(_repository.Register(usuario))
                return usuario;

            return null;
        }

        public tb_usuario ObterUsuarioPorLogin(string login)
        {
            return _repository.Authenticate(login);
        }
    }
}
