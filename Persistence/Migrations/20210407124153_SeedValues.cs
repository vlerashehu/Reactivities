using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 1, "Value Anna" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 2, "Value Nicole" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 3, "Value Bob" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
