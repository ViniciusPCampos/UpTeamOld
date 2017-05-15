namespace UPTEAM.Infra.Data.Context
{
    using UPTEAM.Infra.Data.EntityConfig;
    using UPTEAM.Domain.Entities;
    using System.Data.Entity;

    public partial class UpTeamContext : DbContext
    {
        public UpTeamContext()
            : base("name=UpTeamContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<ta_usuario_conquista> ta_usuario_conquista { get; set; }
        public virtual DbSet<ta_usuario_equipe> ta_usuario_equipe { get; set; }
        public virtual DbSet<ta_usuario_titulo> ta_usuario_titulo { get; set; }
        public virtual DbSet<tb_equipe> tb_equipe { get; set; }
        public virtual DbSet<tb_marco> tb_marco { get; set; }
        public virtual DbSet<tb_mensagem> tb_mensagem { get; set; }
        public virtual DbSet<tb_projeto> tb_projeto { get; set; }
        public virtual DbSet<tb_sprint> tb_sprint { get; set; }
        public virtual DbSet<tb_tarefa> tb_tarefa { get; set; }
        public virtual DbSet<tb_usuario> tb_usuario { get; set; }
        public virtual DbSet<tt_conquista> tt_conquista { get; set; }
        public virtual DbSet<tt_dificuldade> tt_dificuldade { get; set; }
        public virtual DbSet<tt_nivel> tt_nivel { get; set; }
        public virtual DbSet<tt_prioridade> tt_prioridade { get; set; }
        public virtual DbSet<tt_titulo> tt_titulo { get; set; }
        public virtual DbSet<tt_estado_tarefa> tt_estado_tarefa { get; set; }
        public virtual DbSet<tt_tipo_tarefa> tt_tipo_tarefa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConquistaMapping());
            modelBuilder.Configurations.Add(new DificuldadeMapping());
            modelBuilder.Configurations.Add(new EquipeMapping());
            modelBuilder.Configurations.Add(new EstadoTarefaMapping());
            modelBuilder.Configurations.Add(new MarcoMapping());
            modelBuilder.Configurations.Add(new MensagemMapping());
            modelBuilder.Configurations.Add(new NivelMapping());
            modelBuilder.Configurations.Add(new PrioridadeMapping());
            modelBuilder.Configurations.Add(new ProjetoMapping());
            modelBuilder.Configurations.Add(new SprintMapping());
            modelBuilder.Configurations.Add(new TarefaMapping());
            modelBuilder.Configurations.Add(new TipoTarefaMapping());
            modelBuilder.Configurations.Add(new TituloMapping());
            modelBuilder.Configurations.Add(new UsuarioConquistaMapping());
            modelBuilder.Configurations.Add(new UsuarioEquipeMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new UsuarioTituloMapping());
        }
    }
}
