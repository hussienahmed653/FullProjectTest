using FullProjectTest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullProjectTest.Infrastructure.CustomerDemo
{
    public class CustomerDemoConfig : IEntityTypeConfiguration<CustomerDemographics>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographics> builder)
        {
            builder.HasKey(c => c.CustomerTypeId);
        }
    }
}
