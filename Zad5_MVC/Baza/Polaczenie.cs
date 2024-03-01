using Microsoft.EntityFrameworkCore;
using Zad5_MVC.Baza;

namespace Zad5_MVC.Baza.Baza
{
    public class Polaczenie : DbContext
    {
        public DbSet<Tabela> Klienci { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Test;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
