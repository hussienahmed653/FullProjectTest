using FullProjectTest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullProjectTest.Infrastructure.Emp
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(e => e.Manager)
                   .WithMany(e => e.Subordinates)
                   .HasForeignKey(e => e.ReportsTo);
        }
    }
}
