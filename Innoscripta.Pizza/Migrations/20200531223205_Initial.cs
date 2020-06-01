using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Innoscripta.Pizza.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameRu = table.Column<string>(maxLength: 64, nullable: true),
                    NameEng = table.Column<string>(maxLength: 64, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    DescriptionRu = table.Column<string>(maxLength: 1024, nullable: true),
                    DescriptionEng = table.Column<string>(maxLength: 1024, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    LastName = table.Column<string>(maxLength: 128, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 128, nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<DateTime>(nullable: true),
                    CreateUserPlace = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(maxLength: 1024, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Stars = table.Column<byte>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserStatistics",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    OrdersCount = table.Column<int>(nullable: false),
                    TotalOrdersPrice = table.Column<decimal>(nullable: false),
                    Bonus = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatistics", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserStatistics_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Deleted", "DescriptionEng", "DescriptionRu", "Img", "NameEng", "NameRu", "Price", "Type" },
                values: new object[,]
                {
                    { 1, null, "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.", "<b>Состав</b> пицца-соус, сыры «Моцарелла» и «Пармезан», шампиньоны, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", "/images/pizzas/pizzaman.png", "Pizzaman", "Пиццамен", 4m, 1 },
                    { 2, null, "<b>Ingredients:</b> pizza sauce, Mozzarella cheese, pepperoni sausage, champignons.", "<b>Состав</b> пицца-соус, сыр «Моцарелла», колбаса пепперони, шампиньоны.", "/images/pizzas/pepperoni.png", "Pepperoni", "Пепперони", 5m, 1 },
                    { 3, null, "<b>Ingredients:</b> pizza sauce, mozzarella cheese, ham, pineapple.", "<b>Состав</b> пицца-соус, сыр «Моцарелла», ветчина, ананасы.", "/images/pizzas/hawaiian.png", "Hawaiian", "Гавайская", 4m, 1 },
                    { 4, null, "<b>Ingredients:</b> pizza sauce, mozzarella cheese, tomatoes.", "<b>Состав</b> пицца-соус, сыр «Моцарелла», помидоры.", "/images/pizzas/margarita.png", "Margarita", "Маргарита", 4.5m, 1 },
                    { 5, null, "<b>Ingredients:</b> pizza sauce, mozzarella and parmesan cheeses, ham, mushrooms, pepperoni, jalapenos.", "<b>Состав</b> пицца-соус, сыры «Моцарелла» и «Пармезан», ветчина, шампиньоны, колбаса пепперони, перец халапеньо.", "/images/pizzas/dragon.png", "Dragon", "Дракон", 5m, 1 },
                    { 6, null, "<b>Ingredients:</b> mustard sauce, Mozzarella cheese, chicken breast, red onion, mushrooms, garlic.", "<b>Состав</b> соус «Горчичный», сыр «Моцарелла» куриная грудка, лук красный, шампиньоны, чеснок.", "/images/pizzas/chicken-julienne.png", "Chicken julienne", "Куриный жульен", 6.5m, 1 },
                    { 7, null, "<b>Ingredients:</b> pizza sauce, Mozzarella, Parmesan, Cheddar cheeses, blue noble cheese.", "<b>Состав</b> пицца-соус, сыры «Моцарелла», «Пармезан», «Чеддер», сыр с голубой благородной плесенью.", "/images/pizzas/four-cheeses.png", "Four cheeses", "Четыре сыра", 7m, 1 },
                    { 8, null, null, null, "/images/drinks/coca-cola.png", "Coca-cola", "Кока-кола", 2m, 2 },
                    { 9, null, null, null, "/images/drinks/fanta.png", "Fanta", "Фанта", 2m, 2 },
                    { 10, null, null, null, "/images/drinks/cranberry-juice.png", "Сranberry juice", "Морс", 3m, 2 },
                    { 11, null, "", null, "/images/drinks/bon-aqua.png", "Bon aqua", null, 1m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "CreateUserPlace", "Deleted", "LastName", "Name", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { 1, null, 0, null, "Pupkin", "Vasiliy", "ICy5YqxZB1uWSwcVLSNLcA==", "1234567891", 1 },
                    { 2, null, 0, null, "Ivanova", "Mariya", "ICy5YqxZB1uWSwcVLSNLcA==", "1234567892", 1 },
                    { 3, null, 0, null, "Levin", "Petr", "ICy5YqxZB1uWSwcVLSNLcA==", "1234567893", 1 },
                    { 4, null, 0, null, "Bikov", "Ivan", "ICy5YqxZB1uWSwcVLSNLcA==", "1234567894", 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Date", "Deleted", "Stars", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 1, 2, 32, 5, 113, DateTimeKind.Local).AddTicks(2302), null, (byte)2, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 1 },
                    { 22, new DateTime(2020, 5, 30, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3068), null, (byte)5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 21, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3065), null, (byte)3, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 20, new DateTime(2020, 5, 31, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3063), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 19, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3061), null, (byte)2, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 17, new DateTime(2020, 5, 29, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3056), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 16, new DateTime(2020, 5, 30, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3054), null, (byte)5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 15, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3052), null, (byte)3, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 14, new DateTime(2020, 5, 31, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3049), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 13, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3047), null, (byte)2, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 18, new DateTime(2020, 5, 28, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3059), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 3 },
                    { 12, new DateTime(2020, 5, 28, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3045), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 2 },
                    { 11, new DateTime(2020, 5, 29, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3043), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 2 },
                    { 10, new DateTime(2020, 5, 30, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3041), null, (byte)5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 2 },
                    { 9, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3037), null, (byte)3, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 2 },
                    { 8, new DateTime(2020, 5, 31, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3035), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 2 },
                    { 7, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3033), null, (byte)2, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 2 },
                    { 6, new DateTime(2020, 5, 28, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3031), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 1 },
                    { 5, new DateTime(2020, 5, 29, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3026), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 1 },
                    { 4, new DateTime(2020, 5, 30, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3021), null, (byte)5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 1 },
                    { 3, new DateTime(2020, 6, 1, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3018), null, (byte)3, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 1 },
                    { 2, new DateTime(2020, 5, 31, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(2916), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 1 },
                    { 23, new DateTime(2020, 5, 29, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3070), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 },
                    { 24, new DateTime(2020, 5, 28, 2, 32, 5, 114, DateTimeKind.Local).AddTicks(3072), null, (byte)4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "UserStatistics");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
