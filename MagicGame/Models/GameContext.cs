using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Microsoft.Extensions.Configuration;
using MagicGame.Models;



namespace MagicGame.Models
{
    public class GameContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Item> Items { get; set; }

        
        public GameContext()
        {

        }

        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>().HasMany(h => h.Items).WithMany(i => i.Heroes);
        }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString);
        }
        */
    }
}
