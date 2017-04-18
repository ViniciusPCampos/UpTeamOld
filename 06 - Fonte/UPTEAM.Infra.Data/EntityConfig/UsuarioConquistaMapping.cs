using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.Infra.Data.Context;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class UsuarioConquistaMapping : EntityTypeConfiguration<ta_usuario_conquista>
    {
        public UsuarioConquistaMapping()
        {
            HasKey(x => x.idt_usuario_conquista);
        }
    }
}
