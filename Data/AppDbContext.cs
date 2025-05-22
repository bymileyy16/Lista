using Microsoft.EntityFrameworkCore;
using Lista.Models;

namespace Lista.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ListaModel> Listas { get; set; }
    }
}