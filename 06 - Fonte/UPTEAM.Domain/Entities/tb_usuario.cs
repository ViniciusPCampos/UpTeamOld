namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_usuario()
        {
            ta_usuario_conquista = new HashSet<ta_usuario_conquista>();
            ta_usuario_equipe = new HashSet<ta_usuario_equipe>();
            ta_usuario_titulo = new HashSet<ta_usuario_titulo>();
            tb_tarefa = new HashSet<tb_tarefa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idt_usuario { get; set; }

        [Required]
        [StringLength(80)]
        public string nme_usuario { get; set; }

        [StringLength(16)]
        public string tel_usuario { get; set; }

        [Required]
        [StringLength(20)]
        public string lgn_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string pwd_usuario { get; set; }

        [Required]
        [StringLength(45)]
        public string exp_usuario { get; set; }

        public int fk_nivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ta_usuario_conquista> ta_usuario_conquista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ta_usuario_equipe> ta_usuario_equipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ta_usuario_titulo> ta_usuario_titulo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_tarefa> tb_tarefa { get; set; }

        public virtual tt_nivel tt_nivel { get; set; }
    }
}
