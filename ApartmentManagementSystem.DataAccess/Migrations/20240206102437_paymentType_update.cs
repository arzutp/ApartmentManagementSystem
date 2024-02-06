using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class paymentType_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("09ef18c2-340d-407a-b842-0d5d158b4c68"), new Guid("f3ac104f-93f0-4d17-893d-4594fa0bac34") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("09ef18c2-340d-407a-b842-0d5d158b4c68"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3ac104f-93f0-4d17-893d-4594fa0bac34"));

            migrationBuilder.AlterColumn<int>(
                name: "PaymentTypeId",
                table: "PaymentInformations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("e372c8e8-e68d-4759-bab1-8e3812fc7e90"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("acaa97c4-b754-4f30-aa71-1bde1ec80c0c"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEF3Nf2T5IcJTq49tay6CRKvxex41lmbB41XBv4ShTc1EwyMX3rWbUVO5nao64qXGyA==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e372c8e8-e68d-4759-bab1-8e3812fc7e90"), new Guid("acaa97c4-b754-4f30-aa71-1bde1ec80c0c") });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                unique: true,
                filter: "[PaymentTypeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e372c8e8-e68d-4759-bab1-8e3812fc7e90"), new Guid("acaa97c4-b754-4f30-aa71-1bde1ec80c0c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e372c8e8-e68d-4759-bab1-8e3812fc7e90"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("acaa97c4-b754-4f30-aa71-1bde1ec80c0c"));

            migrationBuilder.AlterColumn<int>(
                name: "PaymentTypeId",
                table: "PaymentInformations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("09ef18c2-340d-407a-b842-0d5d158b4c68"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f3ac104f-93f0-4d17-893d-4594fa0bac34"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEO82zU853psAWvyxCEGAoBTiSmbNnBsr2iM8xYUpkWiYweSq1fWNnokXOWrqGCpI5A==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("09ef18c2-340d-407a-b842-0d5d158b4c68"), new Guid("f3ac104f-93f0-4d17-893d-4594fa0bac34") });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
