namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_prioridade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tt_prioridade()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_prioridade { get; set; }

        [Required]
        [StringLength(45)]
        public string des_prioridade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
