using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class paymentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId1",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
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
                name: "PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId1",
                table: "PaymentInformations");

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "PaymentInformations",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "PaymentInformations");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "PaymentInformations",
                type: "int",
                nullable: true);

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
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_PaymentTypeId1",
                table: "PaymentInformations",
                column: "PaymentTypeId1");

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
    }
}
