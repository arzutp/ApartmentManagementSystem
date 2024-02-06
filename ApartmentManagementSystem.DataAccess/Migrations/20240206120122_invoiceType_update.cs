using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class invoiceType_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceTypes_PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e14a8d19-a5f3-4c85-8ffa-5459c1054d1e"), new Guid("b368f366-183b-4cc8-a630-104295384c9e") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e14a8d19-a5f3-4c85-8ffa-5459c1054d1e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b368f366-183b-4cc8-a630-104295384c9e"));

            migrationBuilder.DropColumn(
                name: "PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceTypeId",
                table: "PaymentInformations",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("2ce12364-62ae-4bfe-a70d-433728c48056"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("39f602b4-e7a2-4be9-b39c-d7203da05c74"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEKH5ZjP9C7YW67oBhzzuTIE2AfHYB4E9zYfi2L4HCxXmrFdPqecG9qC+6SspUTDfnw==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("2ce12364-62ae-4bfe-a70d-433728c48056"), new Guid("39f602b4-e7a2-4be9-b39c-d7203da05c74") });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_InvoiceTypeId",
                table: "PaymentInformations",
                column: "InvoiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_InvoiceTypes_InvoiceTypeId",
                table: "PaymentInformations",
                column: "InvoiceTypeId",
                principalTable: "InvoiceTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_InvoiceTypes_InvoiceTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_InvoiceTypeId",
                table: "PaymentInformations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2ce12364-62ae-4bfe-a70d-433728c48056"), new Guid("39f602b4-e7a2-4be9-b39c-d7203da05c74") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ce12364-62ae-4bfe-a70d-433728c48056"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("39f602b4-e7a2-4be9-b39c-d7203da05c74"));

            migrationBuilder.DropColumn(
                name: "InvoiceTypeId",
                table: "PaymentInformations");

            migrationBuilder.AddColumn<int>(
                name: "PaymentInformationId",
                table: "InvoiceTypes",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("e14a8d19-a5f3-4c85-8ffa-5459c1054d1e"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b368f366-183b-4cc8-a630-104295384c9e"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEOauP5g3QyimxFSyC/6yxYu56Vbf5el04svAVD4r/BZ/fwrmOhaunRWvZLyinp/y5g==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e14a8d19-a5f3-4c85-8ffa-5459c1054d1e"), new Guid("b368f366-183b-4cc8-a630-104295384c9e") });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_PaymentInformationId",
                table: "InvoiceTypes",
                column: "PaymentInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes",
                column: "PaymentInformationId",
                principalTable: "PaymentInformations",
                principalColumn: "Id");
        }
    }
}
