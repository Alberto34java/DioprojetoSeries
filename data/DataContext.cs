using Microsoft.EntityFrameworkCore;
using Models;

namespace data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
           optionsBuilder.UseSqlServer("Server=DESKTOP-0V20B0M\\SQLEXPRESS; Database=DigitalSeries_Projeto; User Id=AlbertoDevTeste; Password=asp02");
        }

        public DbSet<Filme> Filmes{ get; set;}
    }
}