﻿// <auto-generated />
using System;
using Innoscripta.Pizza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Innoscripta.Pizza.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.CommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte>("Stars")
                        .HasColumnType("smallint");

                    b.Property<string>("Text")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 298, DateTimeKind.Local).AddTicks(9047),
                            Stars = (byte)2,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5610),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5677),
                            Stars = (byte)3,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5679),
                            Stars = (byte)5,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5682),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5686),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5688),
                            Stars = (byte)2,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 2
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5690),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5691),
                            Stars = (byte)3,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 2
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5694),
                            Stars = (byte)5,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 2
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5695),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 2
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5697),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5698),
                            Stars = (byte)2,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5700),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5701),
                            Stars = (byte)3,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5703),
                            Stars = (byte)5,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5705),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5707),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 3
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5709),
                            Stars = (byte)2,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5710),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5712),
                            Stars = (byte)3,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5713),
                            Stars = (byte)5,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5715),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5716),
                            Stars = (byte)4,
                            Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.OrderItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DescriptionEng")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("DescriptionRu")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<string>("NameEng")
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.Property<string>("NameRu")
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DescriptionEng = "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.",
                            DescriptionRu = "<b>Состав</b> пицца-соус, сыры «Моцарелла» и «Пармезан», шампиньоны, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.",
                            Img = "/images/pizzas/pizzaman.png",
                            NameEng = "Pizzaman",
                            NameRu = "Пиццамен",
                            Price = 4m,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            DescriptionEng = "<b>Ingredients:</b> pizza sauce, Mozzarella cheese, pepperoni sausage, champignons.",
                            DescriptionRu = "<b>Состав</b> пицца-соус, сыр «Моцарелла», колбаса пепперони, шампиньоны.",
                            Img = "/images/pizzas/pepperoni.png",
                            NameEng = "Pepperoni",
                            NameRu = "Пепперони",
                            Price = 5m,
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            DescriptionEng = "<b>Ingredients:</b> pizza sauce, mozzarella cheese, ham, pineapple.",
                            DescriptionRu = "<b>Состав</b> пицца-соус, сыр «Моцарелла», ветчина, ананасы.",
                            Img = "/images/pizzas/hawaiian.png",
                            NameEng = "Hawaiian",
                            NameRu = "Гавайская",
                            Price = 4m,
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            DescriptionEng = "<b>Ingredients:</b> pizza sauce, mozzarella cheese, tomatoes.",
                            DescriptionRu = "<b>Состав</b> пицца-соус, сыр «Моцарелла», помидоры.",
                            Img = "/images/pizzas/margarita.png",
                            NameEng = "Margarita",
                            NameRu = "Маргарита",
                            Price = 4.5m,
                            Type = 1
                        },
                        new
                        {
                            Id = 5,
                            DescriptionEng = "<b>Ingredients:</b> pizza sauce, mozzarella and parmesan cheeses, ham, mushrooms, pepperoni, jalapenos.",
                            DescriptionRu = "<b>Состав</b> пицца-соус, сыры «Моцарелла» и «Пармезан», ветчина, шампиньоны, колбаса пепперони, перец халапеньо.",
                            Img = "/images/pizzas/dragon.png",
                            NameEng = "Dragon",
                            NameRu = "Дракон",
                            Price = 5m,
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            DescriptionEng = "<b>Ingredients:</b> mustard sauce, Mozzarella cheese, chicken breast, red onion, mushrooms, garlic.",
                            DescriptionRu = "<b>Состав</b> соус «Горчичный», сыр «Моцарелла» куриная грудка, лук красный, шампиньоны, чеснок.",
                            Img = "/images/pizzas/chicken-julienne.png",
                            NameEng = "Chicken julienne",
                            NameRu = "Куриный жульен",
                            Price = 6.5m,
                            Type = 1
                        },
                        new
                        {
                            Id = 7,
                            DescriptionEng = "<b>Ingredients:</b> pizza sauce, Mozzarella, Parmesan, Cheddar cheeses, blue noble cheese.",
                            DescriptionRu = "<b>Состав</b> пицца-соус, сыры «Моцарелла», «Пармезан», «Чеддер», сыр с голубой благородной плесенью.",
                            Img = "/images/pizzas/four-cheeses.png",
                            NameEng = "Four cheeses",
                            NameRu = "Четыре сыра",
                            Price = 7m,
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            Img = "/images/drinks/coca-cola.png",
                            NameEng = "Coca-cola",
                            NameRu = "Кока-кола",
                            Price = 2m,
                            Type = 2
                        },
                        new
                        {
                            Id = 9,
                            Img = "/images/drinks/fanta.png",
                            NameEng = "Fanta",
                            NameRu = "Фанта",
                            Price = 2m,
                            Type = 2
                        },
                        new
                        {
                            Id = 10,
                            Img = "/images/drinks/cranberry-juice.png",
                            NameEng = "Сranberry juice",
                            NameRu = "Морс",
                            Price = 3m,
                            Type = 2
                        },
                        new
                        {
                            Id = 11,
                            DescriptionEng = "",
                            Img = "/images/drinks/bon-aqua.png",
                            NameEng = "Bon aqua",
                            NameRu = "Бонаква",
                            Price = 1m,
                            Type = 2
                        });
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreateUserPlace")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Password")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Phone")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateUserPlace = 0,
                            LastName = "Pupkin",
                            Name = "Vasiliy",
                            Password = "ICy5YqxZB1uWSwcVLSNLcA==",
                            Phone = "1234567891",
                            Role = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateUserPlace = 0,
                            LastName = "Ivanova",
                            Name = "Mariya",
                            Password = "ICy5YqxZB1uWSwcVLSNLcA==",
                            Phone = "1234567892",
                            Role = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateUserPlace = 0,
                            LastName = "Levin",
                            Name = "Petr",
                            Password = "ICy5YqxZB1uWSwcVLSNLcA==",
                            Phone = "1234567893",
                            Role = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateUserPlace = 0,
                            LastName = "Bikov",
                            Name = "Ivan",
                            Password = "ICy5YqxZB1uWSwcVLSNLcA==",
                            Phone = "1234567894",
                            Role = 1
                        });
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.UserStatisticEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("UserId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("numeric");

                    b.Property<int>("OrdersCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalOrdersPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("UserStatistics");
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.CommentEntity", b =>
                {
                    b.HasOne("Innoscripta.Pizza.Data.Domain.UserEntity", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.OrderEntity", b =>
                {
                    b.HasOne("Innoscripta.Pizza.Data.Domain.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.OrderItemEntity", b =>
                {
                    b.HasOne("Innoscripta.Pizza.Data.Domain.OrderEntity", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Innoscripta.Pizza.Data.Domain.ProductEntity", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Innoscripta.Pizza.Data.Domain.UserStatisticEntity", b =>
                {
                    b.HasOne("Innoscripta.Pizza.Data.Domain.UserEntity", "User")
                        .WithOne("Statistic")
                        .HasForeignKey("Innoscripta.Pizza.Data.Domain.UserStatisticEntity", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
