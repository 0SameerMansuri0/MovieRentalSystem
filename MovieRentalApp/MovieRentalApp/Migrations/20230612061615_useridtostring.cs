using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalApp.Migrations
{
    public partial class useridtostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_userId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Register",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Register",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "a415835f-7efc-469a-b9bc-1974a983d6e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "aeedd501-08c8-43dc-a96d-162146914bc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "userId" },
                values: new object[] { "3c718dff-8acd-4188-a45e-122614fddc18", "AQAAAAEAACcQAAAAEAUgwl5ES1w1KIWn0Ue9d8f5gY9L7QH1WdRmNdtTsquuggf/mPnYM6JHYMBPINMEXw==", "96273e09-3722-4a9a-a107-872d811038ad", null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_userId",
                table: "AspNetUsers",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_userId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Register");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Register",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "b8e03d37-4aca-4eaa-8570-66bfcf1fe7df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "8984d46f-c294-46a6-abda-a3a21fbb739c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "userId" },
                values: new object[] { "d79c8c3f-f2f2-43c0-963c-ff0a264b16ad", "AQAAAAEAACcQAAAAELbK2XB90w30Grddfm7DP+LVz3aifs57vGTIFFNQp55lrCy8aaUH42KB/nu8F7Z30g==", "6ae84537-b183-47ff-8004-8c8d2073b469", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_userId",
                table: "AspNetUsers",
                column: "userId",
                unique: true);
        }
    }
}
