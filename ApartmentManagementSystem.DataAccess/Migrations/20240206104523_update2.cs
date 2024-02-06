using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTypes_PaymentInformations_PaymentInformationId",
                table: "PaymentTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("51eeb9b7-bd54-4223-9856-bdfaa4d4c5db"), new Guid("fd6ba6ec-0802-4f2c-b532-c6fa940d713d") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("51eeb9b7-bd54-4223-9856-bdfaa4d4c5db"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd6ba6ec-0802-4f2c-b532-c6fa940d713d"));

            migrationBuilder.AlterColumn<int>(
                name: "PaymentInformationId",
                table: "PaymentTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentInformationId",
                table: "InvoiceTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("d6395561-d8f4-475e-8d70-42f49a351e46"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0b8706aa-d8a8-4732-aa27-65bec5212a19"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEACqOlWdw4Gy7+8p6mFc8wrIHu9YFFIH9nmEG2q4ivUFm8siwU1SP+g4wZqEBk4EeQ==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d6395561-d8f4-475e-8d70-42f49a351e46"), new Guid("0b8706aa-d8a8-4732-aa27-65bec5212a19") });

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes",
                column: "PaymentInformationId",
                principalTable: "PaymentInformations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTypes_PaymentInformations_PaymentInformationId",
                table: "PaymentTypes",
                column: "PaymentInformationId",
                principalTable: "PaymentInformations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTypes_PaymentInformations_PaymentInformationId",
                table: "PaymentTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d6395561-d8f4-475e-8d70-42f49a351e46"), new Guid("0b8706aa-d8a8-4732-aa27-65bec5212a19") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d6395561-d8f4-475e-8d70-42f49a351e46"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b8706aa-d8a8-4732-aa27-65bec5212a19"));

            migrationBuilder.AlterColumn<int>(
                name: "PaymentInformationId",
                table: "PaymentTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentInformationId",
                table: "InvoiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("51eeb9b7-bd54-4223-9856-bdfaa4d4c5db"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fd6ba6ec-0802-4f2c-b532-c6fa940d713d"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEJ0JvUwUDjMYz91RVufEOsjD/R5SnZ6MJJe1V2ex0WlYPYJx8g1F/NrjtpfvHYwrYw==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("51eeb9b7-bd54-4223-9856-bdfaa4d4c5db"), new Guid("fd6ba6ec-0802-4f2c-b532-c6fa940d713d") });

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes",
                column: "PaymentInformationId",
                principalTable: "PaymentInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTypes_PaymentInformations_PaymentInformationId",
                table: "PaymentTypes",
                column: "PaymentInformationId",
                principalTable: "PaymentInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
