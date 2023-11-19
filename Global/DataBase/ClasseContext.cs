using Microsoft.EntityFrameworkCore;

namespace Global.Models
{
    public class ClasseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DadosSuplementaresUsr> DadosSuplementaresUsrs { get; set; }
        public ClasseContext(DbContextOptions op) : base(op)
        {
        }

        public ClasseContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // relacionamento 1:1 entre Usuario e DadosSuplementaresUsr
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.DadosSuplementares)
                .WithOne(d => d.Usuario)
                .HasForeignKey<DadosSuplementaresUsr>(d => d.UsuarioId);
        }


    }
}
