using Innoscripta.Pizza.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class CommentEntityConfiguration: IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {

        }
    }
}