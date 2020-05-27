using Innoscripta.Pizza.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class OrderItemEntityConfiguration: IEntityTypeConfiguration<OrderItemEntity>
    {
        public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
        }
    }
}