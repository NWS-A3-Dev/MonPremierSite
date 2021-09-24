using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonPremierSite.DBModels;
using MySqlConnector;

namespace MonPremierSite
{
    public class WebsiteContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=MyWebsite;Uid=root;Pwd=;");

            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(p =>
            {
                p.HasKey(o => o.Id);
                p.Property(o => o.Name);
                p.Property(o => o.Age);
            });
        }
    }
}
