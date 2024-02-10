using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class building_invoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BuildingPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingPayment_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingPayment_InvoiceTypes_InvoiceTypeId",
                        column: x => x.InvoiceTypeId,
                        principalTable: "InvoiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5f458523-bc37-4fd9-837e-43c82b77633e"), null, "Kiracı", "KIRACI" },
                    { new Guid("6b277ecc-be60-4e91-b05a-3921111c2b64"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8683776b-f055-4420-99eb-770b3b273c3f"), 0, "3be1ee34-a90a-45c8-becb-a0e70840fa21", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAECT0rx98Coh2CU111tHBUxCLPdPr871GeNSXv86PXoeq2ZIPdiIo9Ohxah4npOLrKw==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6b277ecc-be60-4e91-b05a-3921111c2b64"), new Guid("8683776b-f055-4420-99eb-770b3b273c3f") });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingPayment_BuildingId",
                table: "BuildingPayment",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingPayment_InvoiceTypeId",
                table: "BuildingPayment",
                column: "InvoiceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingPayment");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5f458523-bc37-4fd9-837e-43c82b77633e"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6b277ecc-be60-4e91-b05a-3921111c2b64"), new Guid("8683776b-f055-4420-99eb-770b3b273c3f") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6b277ecc-be60-4e91-b05a-3921111c2b64"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8683776b-f055-4420-99eb-770b3b273c3f"));

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
    }
}
