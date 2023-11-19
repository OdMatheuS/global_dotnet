using Microsoft.EntityFrameworkCore;

namespace Global.Models
{
    public class ClasseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public ClasseContext(DbContextOptions op) : base(op)
        {
        }

        public ClasseContext() { }


    }
}
