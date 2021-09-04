using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options)
        {
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
