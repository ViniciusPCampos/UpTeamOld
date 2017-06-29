using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UPTEAM.ApplicationServices.Helpers.Criptography;
using UPTEAM.Domain.DTO;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        private ITarefaRepository _tarefaRepository;
        private INivelRepository _nivelRepository;
        private ICryptographyHelper _cript;
        private int _experienciaBase;
        public UsuarioService(IUsuarioRepository usuarioRepository, ICryptographyHelper cript, ITarefaRepository tarefaRepository, INivelRepository nivelRepository)
        {
            _usuarioRepository = usuarioRepository;
            _tarefaRepository = tarefaRepository;
            _nivelRepository = nivelRepository;
            _cript = cript;
            _experienciaBase = int.Parse(ConfigurationSettings.AppSettings["ExperienciaBase"]);
        }
        public tb_usuario Authenticate(string login, string password)
        {
            var user = _usuarioRepository.Authenticate(login);


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

            if(_usuarioRepository.Register(usuario))
                return usuario;

            return null;
        }

        public tb_usuario ObterUsuarioPorLogin(string login)
        {
            return _usuarioRepository.Authenticate(login);
        }

        public UsuarioPerfilDTO ObterPerfilUsuario(string login)
        {
            var usuario = _usuarioRepository.Authenticate(login);
            var tarefasDoUsuario = _tarefaRepository.GetByOwner(usuario.idt_usuario).Where(x => x.idt_estado_tarefa == 4).ToList();

            var perfil = new UsuarioPerfilDTO(usuario.nme_usuario, usuario.lgn_usuario)
            {
                Experiencia = tarefasDoUsuario.Sum(x => (x.tt_dificuldade.mtp_exp_dificuldade * _experienciaBase) +
                                                        (x.tt_prioridade.mtp_exp_prioridade * _experienciaBase))
            };

            perfil.Nivel = _nivelRepository.GetAll().Where(x => x.vlr_exp_max <= perfil.Experiencia).OrderByDescending(x => x.vlr_exp_max).Take(1).FirstOrDefault().nme_nivel;

            return perfil;
        }
        public tb_usuario BuscarPorEmail(string email)
        {
            return _usuarioRepository.BuscarPorEmail(email);
        }
    }
}
