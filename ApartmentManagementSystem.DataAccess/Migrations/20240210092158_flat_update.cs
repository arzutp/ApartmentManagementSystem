using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class flat_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("6dfc0a4b-ebb1-4c1c-9132-9e6c043cf20f"), null, "Kiracı", "KIRACI" },
                    { new Guid("787e4575-b13b-4985-9d44-693ae0d1d9a6"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("22325b52-b079-44a2-9eeb-c8e29fcf5bf8"), 0, "95ab27d6-4398-44cb-966c-57a3daa16c80", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEMMHOqKSsPlhWNHfSFEyLsHeJimutb7kUm9fnR/O/zV5iPGLTSJv0m8pj87RZCgSJA==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("787e4575-b13b-4985-9d44-693ae0d1d9a6"), new Guid("22325b52-b079-44a2-9eeb-c8e29fcf5bf8") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6dfc0a4b-ebb1-4c1c-9132-9e6c043cf20f"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("787e4575-b13b-4985-9d44-693ae0d1d9a6"), new Guid("22325b52-b079-44a2-9eeb-c8e29fcf5bf8") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("787e4575-b13b-4985-9d44-693ae0d1d9a6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("22325b52-b079-44a2-9eeb-c8e29fcf5bf8"));

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
    }
}
