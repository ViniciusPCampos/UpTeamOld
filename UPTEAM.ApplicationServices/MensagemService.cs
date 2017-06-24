using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class MensagemService : IMensagemService
    {
        private MensagemRepository _mensagemRepositorio;

        public MensagemService(MensagemRepository repositorio)
        {
            _mensagemRepositorio = repositorio;
        }

        public List<tb_mensagem> BuscarPorEquipe(int idEquipe)
        {
            return _mensagemRepositorio.BuscarPorEquipe(idEquipe).ToList();
        }

        public tb_mensagem EnviarMensagem(tb_mensagem mensagem)
        {
            try
            {
                mensagem.dta_envio = DateTime.Now;
                _mensagemRepositorio.Add(mensagem);

                return mensagem;
            }
            catch (System.Exception)
            {
                return null;
            }
            
        }
    }
}
