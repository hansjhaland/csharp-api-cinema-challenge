using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Customers> customers = new List<Customers>();
            customers.Add(new Customers { Id = 1, Name = "Nigel", Email = "nigel@nigel.nigel", Phone = "+44729388192", CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            customers.Add(new Customers { Id = 2, Name = "Dave", Email = "dave@dave.dave", Phone = "+44729388180", CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            customers.Add(new Customers { Id = 3, Name = "Walter", Email = "walter@white.bb", Phone = "+44729383492", CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            modelBuilder.Entity<Customers>().HasData(customers);
        }

        public DbSet<Customers> Customers { get; set; }
    }
}
