using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceSystem.Migrations.ApplicationDb
{
    public partial class RoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("ddc8aedc-02b8-4eed-8a62-b6e32d576598"), "468f50d5-5648-4c5a-ab19-da80b4634878", "Admin2", "ADMIN2" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("483a107e-949e-426e-bcb7-e633d2714a57"), "309b0864-3d3c-48d2-a31d-325d416af1b2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("483a107e-949e-426e-bcb7-e633d2714a57"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ddc8aedc-02b8-4eed-8a62-b6e32d576598"));
        }
    }
}
