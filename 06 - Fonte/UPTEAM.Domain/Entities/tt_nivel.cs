namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_nivel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tt_nivel()
        {
            tb_usuario = new HashSet<tb_usuario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_nivel { get; set; }

        public int des_nivel { get; set; }

        public int vlr_exp_max { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario> tb_usuario { get; set; }
    }
}
