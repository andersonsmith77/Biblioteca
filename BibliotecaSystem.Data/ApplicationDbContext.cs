using BibliotecaSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Libros> Libros{ get; set; }
    }
}
