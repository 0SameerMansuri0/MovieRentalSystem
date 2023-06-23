using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalApp.Migrations
{
    public partial class akshay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b", "669d48a4-a1b7-4697-aa90-0f39d792ce93", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b", "0a0061a2-ce3d-4830-be2f-a1caf11b6327", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "confirmPassword", "userId" },
                values: new object[] { "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b", 0, "3df043e6-b53a-4832-98f2-b912579bcd05", "admin@gmail.com", false, null, false, null, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFhdfiCstWotSky5Hcd4c5rZzaNomkR+tTavfcehNLZeNfTDw0NOYYezsN2wO4NqxA==", null, false, "7f822b91-71f2-4255-8dc7-9ff04c333556", false, "admin@gmail.com", null, 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b", "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginModel");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b", "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b");
        }
    }
}
