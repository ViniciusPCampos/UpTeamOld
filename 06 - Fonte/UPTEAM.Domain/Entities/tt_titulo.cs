namespace UPTEAM.Domain.Entities
{
    using System.Collections.Generic;

    public partial class tt_titulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tt_titulo()
        {
            ta_usuario_titulo = new HashSet<ta_usuario_titulo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_titulo { get; set; }

        [Required]
        [StringLength(45)]
        public string nme_titulo { get; set; }

        [Required]
        [StringLength(45)]
        public string dsc_titulo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ta_usuario_titulo> ta_usuario_titulo { get; set; }
    }
}
