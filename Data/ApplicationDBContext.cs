using CarTraders.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Data
{
    internal class ApplicationDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 20)));
        }

        public DbSet<Car> cars { get; set; }
        public DbSet<CarParts> carParts { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<DefaultImage> defaultImage { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }

    }
}
