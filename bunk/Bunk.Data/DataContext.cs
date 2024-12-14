using Bunk.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bunk.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bunker> Bunkers { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my_db");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }


    }
}
