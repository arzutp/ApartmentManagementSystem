using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addYear_RegularlyPayUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d261700f-6521-40db-89ae-521bad68f58c"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"), new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9"));

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "RegularlyPayUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("45fb0411-3704-47bc-aae8-a232adffc447"), null, "Admin", "ADMIN" },
                    { new Guid("59684402-28a9-480c-a169-8b441aaa71cf"), null, "Kiracı", "KIRACI" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("70654f27-971e-42be-8873-7043acf23849"), 0, "9736b7ae-2027-4f1a-ac72-c703948ee19d", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEAj+wqU0PF4m1WT+oH5ktLXf8ystRIkuqHEaVaMbrEa85VIE9r7xvRAX19SOJmZu9A==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("45fb0411-3704-47bc-aae8-a232adffc447"), new Guid("70654f27-971e-42be-8873-7043acf23849") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("59684402-28a9-480c-a169-8b441aaa71cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("45fb0411-3704-47bc-aae8-a232adffc447"), new Guid("70654f27-971e-42be-8873-7043acf23849") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("45fb0411-3704-47bc-aae8-a232adffc447"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70654f27-971e-42be-8873-7043acf23849"));

            migrationBuilder.DropColumn(
                name: "Year",
                table: "RegularlyPayUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"), null, "Admin", "ADMIN" },
                    { new Guid("d261700f-6521-40db-89ae-521bad68f58c"), null, "Kiracı", "KIRACI" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9"), 0, "fba8e4da-0c2e-462e-845d-ce6855325493", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEPX2m57Ihd7Dv7EC8l6JxQgbQBdqzlbF7orzlB0s7TaogPAZDBdSq4cWrtCdroYAEA==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"), new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9") });
        }
    }
}
