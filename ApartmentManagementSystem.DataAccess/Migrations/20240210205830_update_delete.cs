using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_delete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularlyPayUsers_InvoiceTypes_InvoiceTypeId",
                table: "RegularlyPayUsers");

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

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceTypeId",
                table: "RegularlyPayUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations",
                column: "FlatId",
                principalTable: "Flats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularlyPayUsers_InvoiceTypes_InvoiceTypeId",
                table: "RegularlyPayUsers",
                column: "InvoiceTypeId",
                principalTable: "InvoiceTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularlyPayUsers_InvoiceTypes_InvoiceTypeId",
                table: "RegularlyPayUsers");

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

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceTypeId",
                table: "RegularlyPayUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_AspNetUsers_UserId",
                table: "Flats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations",
                column: "FlatId",
                principalTable: "Flats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegularlyPayUsers_InvoiceTypes_InvoiceTypeId",
                table: "RegularlyPayUsers",
                column: "InvoiceTypeId",
                principalTable: "InvoiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
