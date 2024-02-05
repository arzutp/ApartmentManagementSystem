using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class admin_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6b6fe84-443f-4cf8-9de3-30dfcbde1200"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("3886f660-c478-4902-9973-8525ab2e8ddc"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("16000b90-c7e2-493e-aa1c-9dbba7e9e0a2"), 0, "8b2080d3-eb28-469e-b952-71e61385fcca", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEMtiHVZwYTFEcvmBi5ZfoqSHzC9TwWe0AFygB8zMO2g2HAjDjFkkWkNCIxXi0cgoVw==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3886f660-c478-4902-9973-8525ab2e8ddc"), new Guid("16000b90-c7e2-493e-aa1c-9dbba7e9e0a2") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3886f660-c478-4902-9973-8525ab2e8ddc"), new Guid("16000b90-c7e2-493e-aa1c-9dbba7e9e0a2") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3886f660-c478-4902-9973-8525ab2e8ddc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("16000b90-c7e2-493e-aa1c-9dbba7e9e0a2"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b6b6fe84-443f-4cf8-9de3-30dfcbde1200"), 0, "451bdf80-6bb8-4893-8cca-b8e8da61b64f", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAENXdZjw4hJKmQJBiptvhj3bu+T8QwrPYOm1x0gNcunOBvkWWMFZVLa6oxd7OGZHfhg==", null, false, null, "ADMIN", false, "admin" });
        }
    }
}
