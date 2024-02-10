using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_delete1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_AspNetUsers_UserId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3961f2c7-1066-4ef5-a1d0-ab0a63771a19"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("461689a4-1f27-4cc3-8bcb-58693b67c57b"), new Guid("4e5b08ad-e119-4346-95ff-578b3f0e13b5") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("461689a4-1f27-4cc3-8bcb-58693b67c57b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5b08ad-e119-4346-95ff-578b3f0e13b5"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("864fa6ef-4f67-40c9-b8a2-0c8cd7607e0a"), null, "Kiracı", "KIRACI" },
                    { new Guid("c484027e-f680-4662-8997-99d15fd1ee79"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e3fc175b-9e73-4de1-bf14-16ca3ad5ec93"), 0, "69baced5-2921-470d-83dc-12d61aa76e4a", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEAwTF8s08f2qToi977fjKztMxVxpLI+Mln0SwIqaz8YohBJchGea60SyCMOBch5uIg==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c484027e-f680-4662-8997-99d15fd1ee79"), new Guid("e3fc175b-9e73-4de1-bf14-16ca3ad5ec93") });

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_AspNetUsers_UserId",
                table: "PaymentInformations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations",
                column: "FlatId",
                principalTable: "Flats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_AspNetUsers_UserId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("864fa6ef-4f67-40c9-b8a2-0c8cd7607e0a"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c484027e-f680-4662-8997-99d15fd1ee79"), new Guid("e3fc175b-9e73-4de1-bf14-16ca3ad5ec93") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c484027e-f680-4662-8997-99d15fd1ee79"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3fc175b-9e73-4de1-bf14-16ca3ad5ec93"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3961f2c7-1066-4ef5-a1d0-ab0a63771a19"), null, "Kiracı", "KIRACI" },
                    { new Guid("461689a4-1f27-4cc3-8bcb-58693b67c57b"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4e5b08ad-e119-4346-95ff-578b3f0e13b5"), 0, "9a27adca-fe9b-4b7d-a628-1b2461ddba84", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEO3PxGrZxnnPJO4AiASYFfGvFlA5Toho6g56OVfGQHD8rf6QWgCGr6QqF2ZEO0olqA==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("461689a4-1f27-4cc3-8bcb-58693b67c57b"), new Guid("4e5b08ad-e119-4346-95ff-578b3f0e13b5") });

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_AspNetUsers_UserId",
                table: "PaymentInformations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations",
                column: "FlatId",
                principalTable: "Flats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
