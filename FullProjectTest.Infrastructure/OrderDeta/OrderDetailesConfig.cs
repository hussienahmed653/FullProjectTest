using FullProjectTest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullProjectTest.Infrastructure.OrderDeta
{
    public class OrderDetailesConfig : IEntityTypeConfiguration<OrderDetailes>
    {
        public void Configure(EntityTypeBuilder<OrderDetailes> builder)
        {
            builder.HasKey(od => new { od.OrderId, od.ProductId });
            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            builder.HasOne(od => od.Product)
                .WithMany(o => o.OrderDetailes)
                .HasForeignKey(od => od.ProductId);
        }
    }
}
