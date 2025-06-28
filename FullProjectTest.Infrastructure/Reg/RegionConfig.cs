using FullProjectTest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullProjectTest.Infrastructure.Reg
{
    public class RegionConfig : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasMany(e => e.Territories)
                .WithOne(e => e.Region)
                .HasForeignKey(e => e.RegionId);
        }
    }
}
