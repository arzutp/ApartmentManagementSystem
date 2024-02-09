using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add_new_role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92ddb0cb-7fa0-49b3-9313-60002b1ae1d4"), new Guid("4537e759-457c-459a-8aa2-f847e64532d3") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("92ddb0cb-7fa0-49b3-9313-60002b1ae1d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4537e759-457c-459a-8aa2-f847e64532d3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3b32d28b-068d-48c0-bf0a-72ea8b540c79"), null, "Admin", "ADMIN" },
                    { new Guid("c01a689f-1be5-4a8a-8203-1c6bf5387237"), null, "Kiracı", "KIRACI" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a5719045-d1f5-48d7-b20a-989dcb4ca331"), 0, "ead24dbe-ac6d-4a08-9d0b-cdc9c782529f", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEHs3wqyWbDU8j/AHNIoUQ2R+fRlleaMZzM31KgB1sq2wA07uxGS+bf67lW7lHgLcvA==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3b32d28b-068d-48c0-bf0a-72ea8b540c79"), new Guid("a5719045-d1f5-48d7-b20a-989dcb4ca331") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c01a689f-1be5-4a8a-8203-1c6bf5387237"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3b32d28b-068d-48c0-bf0a-72ea8b540c79"), new Guid("a5719045-d1f5-48d7-b20a-989dcb4ca331") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b32d28b-068d-48c0-bf0a-72ea8b540c79"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5719045-d1f5-48d7-b20a-989dcb4ca331"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("92ddb0cb-7fa0-49b3-9313-60002b1ae1d4"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4537e759-457c-459a-8aa2-f847e64532d3"), 0, "ecfb464b-a605-418e-86d9-a6baaef9e804", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEP30W+72rcnIURWr8GnOFBCDWZdphxze5xMsRj3N3ECm9D5Ov17F0sXLttLSeQi+JQ==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("92ddb0cb-7fa0-49b3-9313-60002b1ae1d4"), new Guid("4537e759-457c-459a-8aa2-f847e64532d3") });
        }
    }
}
