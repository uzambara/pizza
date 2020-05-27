using Innoscripta.Pizza.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class OrderEntityConfiguration: IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
        }
    }
}