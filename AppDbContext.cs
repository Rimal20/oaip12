using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Class1;

namespace oaip12
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=zverev;Integrated Security=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Apps)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);
        }
    }
}
