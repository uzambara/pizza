using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Innoscripta.Pizza.Migrations
{
    public partial class COmmentsSeq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 298, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2020, 12, 8, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2020, 12, 9, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2020, 12, 7, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2020, 12, 6, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2020, 12, 5, 16, 4, 37, 299, DateTimeKind.Local).AddTicks(5716));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Comments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 424, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 5, 31, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 5, 29, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 5, 28, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 31, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2020, 5, 29, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2020, 5, 28, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2020, 5, 31, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2020, 5, 29, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2020, 5, 28, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2020, 5, 31, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2020, 6, 1, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2020, 5, 30, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2020, 5, 29, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2020, 5, 28, 10, 52, 49, 425, DateTimeKind.Local).AddTicks(7846));
        }
    }
}
