using System;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.RepositoryInterfaces;

namespace UPTEAM.Infra.Data.Repositories
{
    public class EquipeRepository : RepositoryBase<tb_equipe>, IEquipeRepository
    {
        public IEnumerable<tb_equipe> BuscarEquipePorUsuario(int idt_usuario)
        {
            var query = $@"select e.* from ta_usuario_equipe ue join tb_usuario u on ue.idt_usuario = u.idt_usuario
                            join tb_equipe e on e.idt_equipe = ue.idt_equipe
                            where u.idt_usuario = {idt_usuario}";
            return Db.Database.SqlQuery<tb_equipe>(query);
        }

        public IEnumerable<tb_equipe> BuscarEquipePorNome(string nome)
        {
            return Db.tb_equipe.Where(x => x.nme_equipe.Contains(nome)).ToList();
        }
    }
}
