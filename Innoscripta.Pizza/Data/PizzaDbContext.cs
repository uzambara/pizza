using System.Reflection;
using Innoscripta.Pizza.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Innoscripta.Pizza.Data
{
    public class PizzaDbContext: DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<CommentEntity>()
                .Property(b => b.Id)
                .HasIdentityOptions(startValue: 100);
        }
    }
}
