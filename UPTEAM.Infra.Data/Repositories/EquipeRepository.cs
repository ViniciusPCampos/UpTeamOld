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
            var query = $@"select e.* from ta_usuario_equipe ue join tb_usuario u on ue.idt_usuario = u.idt_usuario
                            join tb_equipe e on e.idt_equipe = ue.idt_equipe
                            where u.idt_usuario = {idt_usuario}";
            return Db.Database.SqlQuery<tb_equipe>(query);
            //return Db.Set<tb_equipe>()
            //    .Join(Db.ta_usuario_equipe, equipe => equipe.idt_equipe, usuarioEquipe => usuarioEquipe.idt_equipe, (equipe, usuarioEquipe) => new { tb_equipe = equipe, ta_usuario_equipe = usuarioEquipe })
            //    .Where(usuarioEquipe => usuarioEquipe.ta_usuario_equipe.idt_usuario == idt_usuario);

        }
    }
}
