using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_AspNetUsers_UserId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_InvoiceTypes_InvoiceTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_InvoiceTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_UserId",
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

            migrationBuilder.DropColumn(
                name: "FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropColumn(
                name: "InvoiceTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PaymentInformations");

            migrationBuilder.AddColumn<int>(
                name: "PaymentInformationId",
                table: "PaymentTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentInformationId",
                table: "InvoiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FlatPaymentInformation",
                columns: table => new
                {
                    FlatsId = table.Column<int>(type: "int", nullable: false),
                    PaymentInformationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatPaymentInformation", x => new { x.FlatsId, x.PaymentInformationsId });
                    table.ForeignKey(
                        name: "FK_FlatPaymentInformation_Flats_FlatsId",
                        column: x => x.FlatsId,
                        principalTable: "Flats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlatPaymentInformation_PaymentInformations_PaymentInformationsId",
                        column: x => x.PaymentInformationsId,
                        principalTable: "PaymentInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInformationUser",
                columns: table => new
                {
                    PaymentInformationsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInformationUser", x => new { x.PaymentInformationsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PaymentInformationUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentInformationUser_PaymentInformations_PaymentInformationsId",
                        column: x => x.PaymentInformationsId,
                        principalTable: "PaymentInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_PaymentInformationId",
                table: "PaymentTypes",
                column: "PaymentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_PaymentInformationId",
                table: "InvoiceTypes",
                column: "PaymentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_FlatPaymentInformation_PaymentInformationsId",
                table: "FlatPaymentInformation",
                column: "PaymentInformationsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformationUser_UsersId",
                table: "PaymentInformationUser",
                column: "UsersId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceTypes_PaymentInformations_PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTypes_PaymentInformations_PaymentInformationId",
                table: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "FlatPaymentInformation");

            migrationBuilder.DropTable(
                name: "PaymentInformationUser");

            migrationBuilder.DropIndex(
                name: "IX_PaymentTypes_PaymentInformationId",
                table: "PaymentTypes");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceTypes_PaymentInformationId",
                table: "InvoiceTypes");

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

            migrationBuilder.DropColumn(
                name: "PaymentInformationId",
                table: "PaymentTypes");

            migrationBuilder.DropColumn(
                name: "PaymentInformationId",
                table: "InvoiceTypes");

            migrationBuilder.AddColumn<int>(
                name: "FlatId",
                table: "PaymentInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceTypeId",
                table: "PaymentInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "PaymentInformations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "PaymentInformations",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_PaymentInformations_FlatId",
                table: "PaymentInformations",
                column: "FlatId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_InvoiceTypeId",
                table: "PaymentInformations",
                column: "InvoiceTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId",
                unique: true,
                filter: "[PaymentTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_UserId",
                table: "PaymentInformations",
                column: "UserId");

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
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInformations_InvoiceTypes_InvoiceTypeId",
                table: "PaymentInformations",
                column: "InvoiceTypeId",
                principalTable: "InvoiceTypes",
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
