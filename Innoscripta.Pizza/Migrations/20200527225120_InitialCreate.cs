using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Innoscripta.Pizza.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
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
                    Deleted = table.Column<DateTime>(nullable: true)
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
                name: "OrderEntity",
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
                    table.PrimaryKey("PK_OrderEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderEntity_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemEntity",
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
                    table.PrimaryKey("PK_OrderItemEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemEntity_OrderEntity_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemEntity_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Deleted", "Description", "Img", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, null, "<b>Ingredients:</b> pizza sauce, Mozzarella and Parmesan cheeses, champignons, bacon, pepperoni sausage, tomatoes, chicken breast, garlic, red onion, greens.", "/images/pizzas/pizzaman.png", "Pizzaman", 4m, 1 },
                    { 2, null, "<b>Ingredients:</b> pizza sauce, Mozzarella cheese, pepperoni sausage, champignons.", "/images/pizzas/pepperoni.png", "Pepperoni", 5m, 1 },
                    { 3, null, "<b>Ingredients:</b> pizza sauce, mozzarella cheese, ham, pineapple.", "/images/pizzas/hawaiian.png", "Hawaiian", 4m, 1 },
                    { 4, null, "<b>Ingredients:</b> pizza sauce, mozzarella cheese, tomatoes.", "/images/pizzas/margarita.png", "Margarita", 4.5m, 1 },
                    { 5, null, "<b>Ingredients:</b> pizza sauce, mozzarella and parmesan cheeses, ham, mushrooms, pepperoni, jalapenos.", "/images/pizzas/dragon.png", "Dragon", 5m, 1 },
                    { 6, null, "<b>Ingredients:</b> mustard sauce, Mozzarella cheese, chicken breast, red onion, mushrooms, garlic.", "/images/pizzas/chicken-julienne.png", "Chicken julienne", 6.5m, 1 },
                    { 7, null, "<b>Ingredients:</b> pizza sauce, Mozzarella, Parmesan, Cheddar cheeses, blue noble cheese.", "/images/pizzas/four-cheeses.png", "Four cheeses", 7m, 1 },
                    { 8, null, null, "/images/drinks/coca-cola.png", "Coca-cola", 2m, 2 },
                    { 9, null, null, "/images/drinks/fanta.png", "Fanta", 2m, 2 },
                    { 10, null, null, "/images/drinks/cranberry-juice.png", "Four cheeses", 3m, 2 },
                    { 11, null, "", "/images/drinks/bon-aqua.png", "Bon aqua", 1m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderEntity_UserId",
                table: "OrderEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemEntity_OrderId",
                table: "OrderItemEntity",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemEntity_ProductId",
                table: "OrderItemEntity",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderItemEntity");

            migrationBuilder.DropTable(
                name: "OrderEntity");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
