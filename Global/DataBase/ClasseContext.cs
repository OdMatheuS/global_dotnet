using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace Global.Models
{
    public class ClasseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DadosSuplementaresUsr> DadosSuplementaresUsrs { get; set; }
        public DbSet<AtualizacaoSaudePub> AtualizacaoSaudePubs { get; set; }
        public DbSet<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePubs { get; set; }
        public DbSet<InfosSaudeUsr> InfosSaudeUsr { get; set; }

        public DbSet<SugestoesSaude> SugestoesSaude { get; set; }

        public DbSet<DuvidasUsuario> DuvidasUsuario { get; set; }
        public ClasseContext(DbContextOptions op) : base(op)
        {
        }

        public ClasseContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //1:1
            modelBuilder.Entity<Usuario>()
                .HasOne(e => e.DadosSuplementares)
                .WithOne(e => e.Usuario)
                .HasForeignKey<DadosSuplementaresUsr>(e => e.UsuarioId);

            //N:M
            modelBuilder.Entity<UsuarioAtualizacaoSaudePub>()
               .HasKey(churros => new { churros.AtSaudePubId, churros.UsuarioId });

            modelBuilder.Entity<UsuarioAtualizacaoSaudePub>()
                .HasOne(ua => ua.UsuarioObj)
                .WithMany(u => u.ListaUsuarioAtualizacaoSaudePub)
                .HasForeignKey(ua => ua.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UsuarioAtualizacaoSaudePub>()
                .HasOne(ua => ua.AtualizacaoObj)
                .WithMany(a => a.ListaUsuarioAtualizacaoSaudePub)
                .HasForeignKey(ua => ua.AtSaudePubId)
                .OnDelete(DeleteBehavior.NoAction);


            //1:N
            modelBuilder.Entity<InfosSaudeUsr>()
               .HasOne(i => i.Usuario)
               .WithMany(u => u.ListaInfosSaude)
               .HasForeignKey(i => i.UsuarioId)
               .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }


    }
}
