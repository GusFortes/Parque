using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace ParqueBLL
{
   public class ParqueContext : DbContext
    {
        public DbSet<Passaporte> Passaportes { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Descontos> Desconto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBParque;Trusted_Connection=True;");
        }
    }
}
