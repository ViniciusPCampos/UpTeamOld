namespace UPTEAM.Infra.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using UPTEAM.Infra.Data.EntityConfig;
    using UPTEAM.Domain.Entities;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EquipeMapping());
            modelBuilder.Configurations.Add(new MarcoMapping());
            modelBuilder.Configurations.Add(new UsuarioConquistaMapping());
            modelBuilder.Configurations.Add(new UsuarioEquipeMapping());
            modelBuilder.Configurations.Add(new UsuarioTituloMapping());

            //modelBuilder.Entity<ta_usuario_titulo>()
            //    .Property(e => e.ta_usuario_titulocol)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_equipe>()
            //    .Property(e => e.nme_equipe)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_equipe>()
            //    .Property(e => e.dsc_equipe)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_equipe>()
            //    .HasMany(e => e.ta_usuario_equipe)
            //    .WithRequired(e => e.tb_equipe)
            //    .HasForeignKey(e => e.fk_equipe)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_equipe>()
            //    .HasMany(e => e.tb_mensagem)
            //    .WithRequired(e => e.tb_equipe)
            //    .HasForeignKey(e => e.fk_equipe)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_equipe>()
            //    .HasMany(e => e.tb_projeto)
            //    .WithRequired(e => e.tb_equipe)
            //    .HasForeignKey(e => e.fk_equipe)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_marco>()
            //    .Property(e => e.nme_marco)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_marco>()
            //    .Property(e => e.dsc_marco)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_mensagem>()
            //    .Property(e => e.txt_mensagem)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_projeto>()
            //    .Property(e => e.nme_projeto)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_projeto>()
            //    .Property(e => e.dsc_projeto)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_projeto>()
            //    .HasMany(e => e.tb_marco)
            //    .WithRequired(e => e.tb_projeto)
            //    .HasForeignKey(e => e.fk_projeto)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_projeto>()
            //    .HasMany(e => e.tb_sprint)
            //    .WithRequired(e => e.tb_projeto)
            //    .HasForeignKey(e => e.fk_projeto)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_sprint>()
            //    .HasMany(e => e.tb_tarefa)
            //    .WithRequired(e => e.tb_sprint)
            //    .HasForeignKey(e => e.fk_sprint)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_tarefa>()
            //    .Property(e => e.nme_tarefa)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_tarefa>()
            //    .Property(e => e.dsc_tarefa)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .Property(e => e.nme_usuario)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .Property(e => e.tel_usuario)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .Property(e => e.lgn_usuario)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .Property(e => e.pwd_usuario)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .Property(e => e.exp_usuario)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .HasMany(e => e.ta_usuario_conquista)
            //    .WithRequired(e => e.tb_usuario)
            //    .HasForeignKey(e => e.fk_usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .HasMany(e => e.ta_usuario_equipe)
            //    .WithRequired(e => e.tb_usuario)
            //    .HasForeignKey(e => e.fk_usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .HasMany(e => e.ta_usuario_titulo)
            //    .WithRequired(e => e.tb_usuario)
            //    .HasForeignKey(e => e.fk_usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tb_usuario>()
            //    .HasMany(e => e.tb_tarefa)
            //    .WithRequired(e => e.tb_usuario)
            //    .HasForeignKey(e => e.fk_usuario)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tt_conquista>()
            //    .Property(e => e.nme_conquista)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_conquista>()
            //    .Property(e => e.dsc_conquista)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_conquista>()
            //    .HasMany(e => e.ta_usuario_conquista)
            //    .WithRequired(e => e.tt_conquista)
            //    .HasForeignKey(e => e.fk_conquista)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tt_dificuldade>()
            //    .Property(e => e.nme_dificuldade)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_dificuldade>()
            //    .Property(e => e.dsc_dificuldade)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_dificuldade>()
            //    .HasMany(e => e.tb_tarefa)
            //    .WithRequired(e => e.tt_dificuldade)
            //    .HasForeignKey(e => e.fk_dificuldade)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tt_nivel>()
            //    .HasMany(e => e.tb_usuario)
            //    .WithRequired(e => e.tt_nivel)
            //    .HasForeignKey(e => e.fk_nivel)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tt_prioridade>()
            //    .Property(e => e.des_prioridade)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_prioridade>()
            //    .HasMany(e => e.tb_tarefa)
            //    .WithRequired(e => e.tt_prioridade)
            //    .HasForeignKey(e => e.fk_prioridade)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<tt_titulo>()
            //    .Property(e => e.nme_titulo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_titulo>()
            //    .Property(e => e.dsc_titulo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<tt_titulo>()
            //    .HasMany(e => e.ta_usuario_titulo)
            //    .WithRequired(e => e.tt_titulo)
            //    .HasForeignKey(e => e.fk_titulo)
            //    .WillCascadeOnDelete(false);
        }
    }
}
