namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_conquista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tt_conquista()
        {
            ta_usuario_conquista = new HashSet<ta_usuario_conquista>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_conquista { get; set; }

        [Required]
        [StringLength(80)]
        public string nme_conquista { get; set; }

        [Required]
        [StringLength(45)]
        public string dsc_conquista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ta_usuario_conquista> ta_usuario_conquista { get; set; }
    }
}
