using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class ProjetoService : IProjetoService
    {
        private readonly ProjetoRepository _projetoRepositorio;

        public ProjetoService(ProjetoRepository repositorio)
        {
            _projetoRepositorio = repositorio;
        }

        public void AtualizarProjeto(tb_projeto projeto)
        {
            _projetoRepositorio.Update(projeto);
        }

        public List<tb_projeto> BuscarPorEquipe(int idEquipe)
        {
            return _projetoRepositorio.BuscarPorEquipe(idEquipe).ToList();
        }

        public List<tb_projeto> BuscarPorNome(string nomeProjeto)
        {
            return _projetoRepositorio.BuscarPorNome(nomeProjeto).ToList();
        }

        public List<tb_projeto> BuscarPorUsuario(tb_usuario usuario)
        {
            return _projetoRepositorio.BuscarPorUsuario(usuario);
        }

        public IEnumerable<tb_projeto> BuscarProjetosTarefasPorUsuario(int idUsuario)
        {
            return _projetoRepositorio.BuscarProjetosTarefasPorUsuario(idUsuario);
        }

        public tb_projeto CriarNovoProjeto(tb_projeto projeto)
        {
            try
            {
                _projetoRepositorio.Add(projeto);

                return projeto;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void ExcluirProjeto(tb_projeto projeto)
        {
            _projetoRepositorio.Remove(projeto);
        }

        public tb_projeto BuscarPorID(int id)
        {
            return _projetoRepositorio.BuscarProjetoPorId(id);
        }
    }
}
