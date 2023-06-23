using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalApp.Migrations
{
    public partial class sadsadsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "08f0e6e1-2b5d-4370-b8eb-e8a134435701");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "9e583acf-d6aa-4f15-9c56-977fde40d11a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8ec6aa4-7e89-4023-a7df-21289e832959", "AQAAAAEAACcQAAAAEP7C+lnW5mOlFaZsPbnbvumwZDDdDYhcTBVNYPzbqOXKJXxjhSKTBskkSJGfG9Qv/A==", "714d8b7c-d5f9-4087-b1a4-498d8207ac3f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "669d48a4-a1b7-4697-aa90-0f39d792ce93");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "0a0061a2-ce3d-4830-be2f-a1caf11b6327");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3df043e6-b53a-4832-98f2-b912579bcd05", "AQAAAAEAACcQAAAAEFhdfiCstWotSky5Hcd4c5rZzaNomkR+tTavfcehNLZeNfTDw0NOYYezsN2wO4NqxA==", "7f822b91-71f2-4255-8dc7-9ff04c333556" });
        }
    }
}
