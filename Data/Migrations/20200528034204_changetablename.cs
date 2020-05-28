using Microsoft.EntityFrameworkCore.Migrations;

namespace trash.Data.Migrations
{
    public partial class changetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8f1a75a-1c0c-444a-93f4-50d73dfa2dd1", "f261deda-2278-4478-b105-b73c7ff5c2c2", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8f1a75a-1c0c-444a-93f4-50d73dfa2dd1");
        }
    }
}
