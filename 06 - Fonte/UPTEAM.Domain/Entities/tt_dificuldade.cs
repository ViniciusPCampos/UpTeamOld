namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_dificuldade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tt_dificuldade()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_dificuldade { get; set; }

        [Required]
        [StringLength(80)]
        public string nme_dificuldade { get; set; }

        [Required]
        [StringLength(100)]
        public string dsc_dificuldade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
