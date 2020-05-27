using System.Reflection;
using Microsoft.EntityFrameworkCore;

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
        }
    }
}