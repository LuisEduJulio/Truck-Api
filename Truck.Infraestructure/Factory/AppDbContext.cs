using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Truck.Domain.Entities;

namespace Truck.Infraestructure.Factory
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TruckEntity> TruckEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}