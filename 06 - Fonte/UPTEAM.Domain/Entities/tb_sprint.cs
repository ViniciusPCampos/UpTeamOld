namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_sprint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_sprint()
        {
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_sprint { get; set; }

        public int vlr_iteracao_sprint { get; set; }

        [Column(TypeName = "date")]
        public DateTime dta_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime dta_termino { get; set; }

        public int fk_projeto { get; set; }

        public virtual tb_projeto tb_projeto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }
    }
}
