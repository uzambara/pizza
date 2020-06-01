using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Innoscripta.Pizza.Data
{
    public class PizzaDbContextFactory : IDesignTimeDbContextFactory<PizzaDbContext>
    {
        public PizzaDbContext CreateDbContext(string[] args)
        {
            var configuration = Program.Configuration;
            string connectionString = configuration.GetConnectionString("pizza");

            var builder = new DbContextOptionsBuilder<PizzaDbContext>();
            builder.UseNpgsql(connectionString, optionsBuilder => optionsBuilder.UseRelationalNulls(true));
            return new PizzaDbContext(builder.Options);
        }
    }
}