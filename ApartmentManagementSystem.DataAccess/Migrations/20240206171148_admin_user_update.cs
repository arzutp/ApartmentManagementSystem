using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class admin_user_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f80b5a0c-4954-4fbe-af7a-2a819238eb47"), new Guid("f7d1a916-1def-4cff-9307-d17e22f635e6") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f80b5a0c-4954-4fbe-af7a-2a819238eb47"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f7d1a916-1def-4cff-9307-d17e22f635e6"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("2ba20594-21b6-44aa-a619-88bb97b1d5d0"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("56ac6678-c23b-43ef-b2a3-5ce802277cd3"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEHZAOptADaGS9n7+98gza6uqfgJLUdHqVDj5WYBDlVFOL32IkmaWw3IfHvu3ZvQM1w==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2ba20594-21b6-44aa-a619-88bb97b1d5d0"), new Guid("56ac6678-c23b-43ef-b2a3-5ce802277cd3") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2ba20594-21b6-44aa-a619-88bb97b1d5d0"), new Guid("56ac6678-c23b-43ef-b2a3-5ce802277cd3") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ba20594-21b6-44aa-a619-88bb97b1d5d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("56ac6678-c23b-43ef-b2a3-5ce802277cd3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("f80b5a0c-4954-4fbe-af7a-2a819238eb47"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f7d1a916-1def-4cff-9307-d17e22f635e6"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEBE0iGO4TyNErwfZpdTX//JQ0kvv2+FOPrbatoN+RQUjy/sCsUTCovil/Waivptdfw==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f80b5a0c-4954-4fbe-af7a-2a819238eb47"), new Guid("f7d1a916-1def-4cff-9307-d17e22f635e6") });
        }
    }
}
