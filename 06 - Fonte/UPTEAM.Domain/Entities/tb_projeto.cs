namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_projeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_projeto()
        {
            tb_marco = new HashSet<tb_marco>();
            tb_sprint = new HashSet<tb_sprint>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_projeto { get; set; }

        [Required]
        [StringLength(80)]
        public string nme_projeto { get; set; }

        [Required]
        [StringLength(200)]
        public string dsc_projeto { get; set; }

        [Column(TypeName = "date")]
        public DateTime dta_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime dta_termino { get; set; }

        public int fk_equipe { get; set; }

        public virtual tb_equipe tb_equipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_marco> tb_marco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sprint> tb_sprint { get; set; }
    }
}
