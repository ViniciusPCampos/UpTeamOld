using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.ApplicationServices
{
    public class ProjetoService : IProjetoService
    {
        private ProjetoRepository _projetoRepository;
        public ProjetoService(ProjetoRepository repository)
        {
            _projetoRepository = repository;
        }
        public void AtualizarProjeto(tb_projeto projeto)
        {
            _projetoRepository.Update(projeto);
        }

        public List<tb_projeto> BuscarProjetosPorEquipe(tb_equipe equipe)
        {
            return _projetoRepository.GetProjectByTeam(equipe.idt_equipe).ToList();
        }

        public void CriarNovoProjeto(tb_projeto projeto)
        {
            _projetoRepository.Add(projeto);
        }

        public void ExcluirProjeto(tb_projeto projeto)
        {
            _projetoRepository.Remove(projeto);
        }
    }
}
