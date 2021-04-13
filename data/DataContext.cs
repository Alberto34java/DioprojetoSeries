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
          
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Filme>().HasKey(p => p.Id );
           modelBuilder.Entity<Filme>().HasIndex(p => p.Nome).IsUnique();
           modelBuilder.Entity<Filme>().Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
           modelBuilder.Entity<Filme>().Property(p => p.Genero).IsRequired();
           modelBuilder.Entity<Filme>().Property(p => p.Descricao).HasColumnType("VARCHAR(200)").IsRequired();
            modelBuilder.Entity<Filme>().Property(p => p.AnoLancamento).IsRequired();
           
           //HasColumnType("VARCHAR(80)").IsRequired();
        }  
        public DbSet<Filme> Filmes{ get; set;}
    }
}