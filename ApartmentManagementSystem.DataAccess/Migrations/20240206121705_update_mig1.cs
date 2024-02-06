using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"), new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb"));

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId1",
                table: "PaymentInformations",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("3c355f93-883a-478c-b55a-0b6ad9c7f19e"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("10a798c2-175f-4404-9b4d-4e6a2aacf4e7"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEDYtAy6BCPj4mWAJaZ8cutcI6YBO0u043Xlra8Fnibmzv9eSg6GQn5wjpzjPjyYgRQ==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3c355f93-883a-478c-b55a-0b6ad9c7f19e"), new Guid("10a798c2-175f-4404-9b4d-4e6a2aacf4e7") });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_PaymentTypeId1",
                table: "PaymentInformations",
                column: "PaymentTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations",
                column: "FlatId",
                principalTable: "Flats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId1",
                table: "PaymentInformations",
                column: "PaymentTypeId1",
                principalTable: "PaymentTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId1",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_PaymentTypeId1",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3c355f93-883a-478c-b55a-0b6ad9c7f19e"), new Guid("10a798c2-175f-4404-9b4d-4e6a2aacf4e7") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3c355f93-883a-478c-b55a-0b6ad9c7f19e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10a798c2-175f-4404-9b4d-4e6a2aacf4e7"));

            migrationBuilder.DropColumn(
                name: "PaymentTypeId1",
                table: "PaymentInformations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEGSF8nuR0xmm2Mb6iUsiOEqqtGF04SqKxpvKkSJ4Z/g5SyQyeIKRmHXW5O3bgoxEpQ==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"), new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb") });

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations",
                column: "FlatId",
                principalTable: "Flats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id");
        }
    }
}
