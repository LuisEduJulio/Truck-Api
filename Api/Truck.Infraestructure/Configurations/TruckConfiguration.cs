using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truck.Domain.Entities;

namespace Truck.Infraestructure.Configurations
{
    public class TruckConfiguration : IEntityTypeConfiguration<TruckEntity>
    {
        public void Configure(EntityTypeBuilder<TruckEntity> builder)
        {
            builder
                .HasKey(p => p.Id);
        }
    }
}