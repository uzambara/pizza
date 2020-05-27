using System.Collections.Generic;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class ProductEntityConfiguration: IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasData(new List<ProductEntity>()
            {
                new ProductEntity()
                {
                    Id = 1,
                    Description = "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
                    Img = "/images/pizzas/pizzaman.png",
                    Name = "Pizzaman",
                    Price = 4,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = 2,
                    Description = "<b>Ingredients:</b> pizza sauce, Mozzarella cheese, pepperoni sausage, champignons.",
                    Img = "/images/pizzas/pepperoni.png",
                    Name = "Pepperoni",
                    Price = 5,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = 3,
                    Description = "<b>Ingredients:</b> pizza sauce, mozzarella cheese, ham, pineapple.",
                    Img = "/images/pizzas/hawaiian.png",
                    Name = "Hawaiian",
                    Price = 4,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = 4,
                    Description = "<b>Ingredients:</b> pizza sauce, mozzarella cheese, tomatoes.",
                    Img = "/images/pizzas/margarita.png",
                    Name = "Margarita",
                    Price = 4.5m,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = 5,
                    Description = "<b>Ingredients:</b> pizza sauce, mozzarella and parmesan cheeses, ham, mushrooms, pepperoni, jalapenos.",
                    Img = "/images/pizzas/dragon.png",
                    Name = "Dragon",
                    Price = 5,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = 6,
                    Description = "<b>Ingredients:</b> mustard sauce, Mozzarella cheese, chicken breast, red onion, mushrooms, garlic.",
                    Img = "/images/pizzas/chicken-julienne.png",
                    Name = "Chicken julienne",
                    Price = 6.5m,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = 7,
                    Description = "<b>Ingredients:</b> pizza sauce, Mozzarella, Parmesan, Cheddar cheeses, blue noble cheese.",
                    Img = "/images/pizzas/four-cheeses.png",
                    Name = "Four cheeses",
                    Price = 7,
                    Type = ProductType.Pizza
                },

                new ProductEntity()
                {
                    Id = 8,
                    Description = null,
                    Img = "/images/drinks/coca-cola.png",
                    Name = "Coca-cola",
                    Price = 2,
                    Type = ProductType.Drink
                },
                new ProductEntity()
                {
                    Id = 9,
                    Description = null,
                    Img = "/images/drinks/fanta.png",
                    Name = "Fanta",
                    Price = 2,
                    Type = ProductType.Drink
                },
                new ProductEntity()
                {
                    Id = 10,
                    Description = null,
                    Img = "/images/drinks/cranberry-juice.png",
                    Name = "Four cheeses",
                    Price = 3,
                    Type = ProductType.Drink
                },
                new ProductEntity()
                {
                    Id = 11,
                    Description = "",
                    Img = "/images/drinks/bon-aqua.png",
                    Name = "Bon aqua",
                    Price = 1,
                    Type = ProductType.Drink
                }
            });
        }
    }
}