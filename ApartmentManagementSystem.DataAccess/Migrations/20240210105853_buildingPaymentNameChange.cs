using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class buildingPaymentNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BuildingInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingInvoices_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingInvoices_InvoiceTypes_InvoiceTypeId",
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
                    { new Guid("1285726c-971f-4708-8adc-69ab2933782f"), null, "Admin", "ADMIN" },
                    { new Guid("9a488ff6-5f5c-44c9-b9ff-be14a63ddc3a"), null, "Kiracı", "KIRACI" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7ece46d5-413c-4eb2-8291-5c26e6c1a752"), 0, "380f3a84-f1a5-465b-85aa-70fb11717531", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEBrXcHhkpOg2G7qMrblGtoD2uvtmehZCxPf2AunSszutO2UKIPmH92s5ZZmrJTSCRg==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1285726c-971f-4708-8adc-69ab2933782f"), new Guid("7ece46d5-413c-4eb2-8291-5c26e6c1a752") });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingInvoices_BuildingId",
                table: "BuildingInvoices",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingInvoices_InvoiceTypeId",
                table: "BuildingInvoices",
                column: "InvoiceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingInvoices");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9a488ff6-5f5c-44c9-b9ff-be14a63ddc3a"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1285726c-971f-4708-8adc-69ab2933782f"), new Guid("7ece46d5-413c-4eb2-8291-5c26e6c1a752") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1285726c-971f-4708-8adc-69ab2933782f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ece46d5-413c-4eb2-8291-5c26e6c1a752"));

            migrationBuilder.CreateTable(
                name: "BuildingPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
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
    }
}
