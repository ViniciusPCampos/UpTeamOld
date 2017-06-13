using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public  class MarcoService : IMarcoService
    {
        private readonly MarcoRepository _marcoRepositorio;
        
        public MarcoService(MarcoRepository repositorio)
        {
            _marcoRepositorio = repositorio;
        }

        public void AlterarMarco(tb_marco marco)
        {
            _marcoRepositorio.Update(marco);
        }

        public tb_marco BuscarMarco(int idMarco)
        {
            return _marcoRepositorio.GetById(idMarco);
        }

        public List<tb_marco> BuscarPorProjeto(int idProjeto)
        {
            return _marcoRepositorio.BuscarPorProjeto(idProjeto).ToList();
        }

        public tb_marco CriarNovaMarco(tb_marco marco)
        {
            try
            {
                _marcoRepositorio.Add(marco);
                return marco;
            }
            catch
            {
                return null;
            }
        }

        public void DeletarMarco(tb_marco marco)
        {
            _marcoRepositorio.Remove(marco);
        }
    }
}
