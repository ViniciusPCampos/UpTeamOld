using System.Data.Entity.ModelConfiguration;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Infra.Data.EntityConfig
{
    public class MensagemMapping : EntityTypeConfiguration<tb_mensagem>
    {
        public MensagemMapping()
        {
            HasKey(x => x.idt_mensagem);

            Property(x => x.txt_mensagem)
                .IsRequired()
                .HasMaxLength(500);

        }
    }
}
