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
                    Id = -1,
                    DescriptionEng = "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
                    DescriptionRu = "<b>Состав</b> пицца-соус, сыры «Моцарелла» и «Пармезан», шампиньоны, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.",
                    Img = "/images/pizzas/pizzaman.png",
                    NameEng = "Pizzaman",
                    NameRu = "Пиццамен",
                    Price = 4,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = -2,
                    DescriptionEng = "<b>Ingredients:</b> pizza sauce, Mozzarella cheese, pepperoni sausage, champignons.",
                    DescriptionRu = "<b>Состав</b> пицца-соус, сыр «Моцарелла», колбаса пепперони, шампиньоны.",
                    Img = "/images/pizzas/pepperoni.png",
                    NameEng = "Pepperoni",
                    NameRu = "Пепперони",
                    Price = 5,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = -3,
                    DescriptionEng = "<b>Ingredients:</b> pizza sauce, mozzarella cheese, ham, pineapple.",
                    DescriptionRu = "<b>Состав</b> пицца-соус, сыр «Моцарелла», ветчина, ананасы.",
                    Img = "/images/pizzas/hawaiian.png",
                    NameEng = "Hawaiian",
                    NameRu = "Гавайская",
                    Price = 4,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = -4,
                    DescriptionEng = "<b>Ingredients:</b> pizza sauce, mozzarella cheese, tomatoes.",
                    DescriptionRu = "<b>Состав</b> пицца-соус, сыр «Моцарелла», помидоры.",
                    Img = "/images/pizzas/margarita.png",
                    NameEng = "Margarita",
                    NameRu = "Маргарита",
                    Price = 4.5m,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = -5,
                    DescriptionEng = "<b>Ingredients:</b> pizza sauce, mozzarella and parmesan cheeses, ham, mushrooms, pepperoni, jalapenos.",
                    DescriptionRu = "<b>Состав</b> пицца-соус, сыры «Моцарелла» и «Пармезан», ветчина, шампиньоны, колбаса пепперони, перец халапеньо.",
                    Img = "/images/pizzas/dragon.png",
                    NameEng = "Dragon",
                    NameRu = "Дракон",
                    Price = 5,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = -6,
                    DescriptionEng = "<b>Ingredients:</b> mustard sauce, Mozzarella cheese, chicken breast, red onion, mushrooms, garlic.",
                    DescriptionRu = "<b>Состав</b> соус «Горчичный», сыр «Моцарелла» куриная грудка, лук красный, шампиньоны, чеснок.",
                    Img = "/images/pizzas/chicken-julienne.png",
                    NameEng = "Chicken julienne",
                    NameRu = "Куриный жульен",
                    Price = 6.5m,
                    Type = ProductType.Pizza
                },
                new ProductEntity()
                {
                    Id = -7,
                    DescriptionEng = "<b>Ingredients:</b> pizza sauce, Mozzarella, Parmesan, Cheddar cheeses, blue noble cheese.",
                    DescriptionRu = "<b>Состав</b> пицца-соус, сыры «Моцарелла», «Пармезан», «Чеддер», сыр с голубой благородной плесенью.",
                    Img = "/images/pizzas/four-cheeses.png",
                    NameEng = "Four cheeses",
                    NameRu = "Четыре сыра",
                    Price = 7,
                    Type = ProductType.Pizza
                },

                new ProductEntity()
                {
                    Id = -8,
                    DescriptionEng = null,
                    DescriptionRu = null,
                    Img = "/images/drinks/coca-cola.png",
                    NameEng = "Coca-cola",
                    NameRu = "Кока-кола",
                    Price = 2,
                    Type = ProductType.Drink
                },
                new ProductEntity()
                {
                    Id = -9,
                    DescriptionEng = null,
                    DescriptionRu = null,
                    Img = "/images/drinks/fanta.png",
                    NameEng = "Fanta",
                    NameRu = "Фанта",
                    Price = 2,
                    Type = ProductType.Drink
                },
                new ProductEntity()
                {
                    Id = -10,
                    DescriptionEng = null,
                    DescriptionRu = null,
                    Img = "/images/drinks/cranberry-juice.png",
                    NameEng = "Сranberry juice",
                    NameRu = "Морс",
                    Price = 3,
                    Type = ProductType.Drink
                },
                new ProductEntity()
                {
                    Id = -11,
                    DescriptionEng = "",
                    DescriptionRu = null,
                    Img = "/images/drinks/bon-aqua.png",
                    NameEng = "Bon aqua",
                    NameRu = "Бонаква",
                    Price = 1,
                    Type = ProductType.Drink
                }
            });
        }
    }
}