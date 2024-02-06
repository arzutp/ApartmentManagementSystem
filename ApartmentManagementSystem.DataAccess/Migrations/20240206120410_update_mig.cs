using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "PaymentInformationId",
                table: "PaymentTypes");

            migrationBuilder.AddColumn<int>(
                name: "FlatId",
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
                values: new object[] { new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb"), 0, "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEGSF8nuR0xmm2Mb6iUsiOEqqtGF04SqKxpvKkSJ4Z/g5SyQyeIKRmHXW5O3bgoxEpQ==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"), new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb") });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_FlatId",
                table: "PaymentInformations",
                column: "FlatId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformations_PaymentTypeId",
                table: "PaymentInformations",
                column: "PaymentTypeId");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_PaymentInformations_AspNetUsers_UserId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_Flats_FlatId",
                table: "PaymentInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInformations_PaymentTypes_PaymentTypeId",
                table: "PaymentInformations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInformations_FlatId",
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
                keyValues: new object[] { new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"), new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6cb3fd21-c286-4522-9695-a5647debd7f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("96bf5cbd-b71a-4825-a80a-954cabf68bcb"));

            migrationBuilder.DropColumn(
                name: "FlatId",
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
                nullable: true);

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
                name: "IX_PaymentTypes_PaymentInformationId",
                table: "PaymentTypes",
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
                name: "FK_PaymentTypes_PaymentInformations_PaymentInformationId",
                table: "PaymentTypes",
                column: "PaymentInformationId",
                principalTable: "PaymentInformations",
                principalColumn: "Id");
        }
    }
}
