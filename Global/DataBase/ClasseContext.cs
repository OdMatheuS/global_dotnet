using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Global.Models
{
    public class ClasseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DadosSuplementaresUsr> DadosSuplementaresUsrs { get; set; }
        public DbSet<AtualizacaoSaudePub> AtualizacaoSaudePubs { get; set; }
        public DbSet<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePubs { get; set; }
        public ClasseContext(DbContextOptions op) : base(op)
        {
        }

        public ClasseContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // relacionamento 1:1 entre Usuario e DadosSuplementaresUsr
            /*
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.DadosSuplementares)
                .WithOne(d => d.Usuario)
                .HasForeignKey<DadosSuplementaresUsr>(d => d.Id);
            */

            /*
            //WIP
            //chave composta da tabela associativa
            modelBuilder.Entity<UsuarioAtualizacaoSaudePub>()
                .HasKey(c => new { c.UsuarioId, c.AtualizacaoSaudePubId});

            //WIP
            //Configura a relação da tabela associativa com o ator
            modelBuilder.Entity<UsuarioAtualizacaoSaudePub>()
                .HasOne(f => f.Usuarios)
                .WithMany(f => f.UsuarioAtualizacaoSaudePublicas)
                .HasForeignKey(f => f.UsuarioId);

            //WIP
            //Configura a relação da tabela associativa com o filme
            modelBuilder.Entity<UsuarioAtualizacaoSaudePub>()
               .HasOne(f => f.AtualizacaoSaudePubs)
               .WithMany(f => f.UsuarioAtualizacaoSaudePublicas)
               .HasForeignKey(f => f.AtualizacaoSaudePubId);

            base.OnModelCreating(modelBuilder);
            */

            modelBuilder.Entity<Usuario>()
                .HasOne(e => e.DadosSuplementares)
            .WithOne(e => e.Usuario)
                .HasForeignKey<DadosSuplementaresUsr>(e => e.UsuarioId)
                .IsRequired();
            base.OnModelCreating(modelBuilder);
        }


    }
}
