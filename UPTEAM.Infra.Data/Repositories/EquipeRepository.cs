using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class EquipeRepository : RepositoryBase<tb_equipe>, IEquipeRepository
    {
        public IEnumerable<tb_equipe> GetTeamsByUser(int idt_usuario)
        {
            return Db.Set<tb_equipe>()
                .Join(Db.ta_usuario_equipe, equipe => equipe.idt_equipe, usuarioEquipe => usuarioEquipe.idt_equipe, (EquipeRepository, usuarioEquipe) => new { tb_equipe = equipe, ta_usuario_equipe = usuarioEquipe })
                .Where(usuarioEquipe => usuarioEquipe.ta_usuario_equipe.idt_usuario == idt_usuario);

        }
    }
}
