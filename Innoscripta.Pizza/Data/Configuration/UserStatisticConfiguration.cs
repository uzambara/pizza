using Innoscripta.Pizza.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class UserStatisticConfiguration: IEntityTypeConfiguration<UserStatisticEntity>
    {
        public void Configure(EntityTypeBuilder<UserStatisticEntity> builder)
        {
        }
    }
}