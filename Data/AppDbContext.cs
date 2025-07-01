using Microsoft.EntityFrameworkCore;
using ProjetoDBZ.models;

namespace ProjetoDBZ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Personagem> DBZ { get; set;}
    }
}