using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalApp.Migrations
{
    public partial class sadsadsafdhg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "668eab08-a513-4ecb-bd58-282b744ce4d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "8231ab73-3d8f-4a37-854a-b3e74712044e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb6000f9-d0b6-47ec-961d-0772ab1148ef", "AQAAAAEAACcQAAAAEE+FU866M6hZywm9Ms0MHueWeVnyoXbUETmoYghpTY9+ht4Gf8EnUPBwIg0AEoSzrg==", "0ad50285-c466-405d-900c-a7551f7a4201" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "cb7d411b-05da-49b6-9a15-dd2c13f5bd35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "ab1d98b1-ad4d-49e5-8cdd-01af798a4b45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f3a799a-ef63-4566-8ab2-39774528c8dc", "AQAAAAEAACcQAAAAEHy4kmMhI4hwVRE3SlHdkK6b/UUBeSZT1liUAPhKhc2lGMlI8E2Rq/1uHDuz0HoAwA==", "0d3c7bb5-9e39-4244-98bf-c716fed18620" });
        }
    }
}
