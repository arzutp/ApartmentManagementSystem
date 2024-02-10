using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class regurarly_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e8c7162-5d67-4ad3-9616-c7b0d94cbc57"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6947bdb8-c3ac-4c17-b973-0dea5914bf3c"), new Guid("143fa954-1964-404b-b1ae-52536f240c95") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6947bdb8-c3ac-4c17-b973-0dea5914bf3c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("143fa954-1964-404b-b1ae-52536f240c95"));

            migrationBuilder.CreateTable(
                name: "RegularlyPayUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularlyPayUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegularlyPayUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegularlyPayUsers_InvoiceTypes_InvoiceTypeId",
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
                    { new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"), null, "Admin", "ADMIN" },
                    { new Guid("d261700f-6521-40db-89ae-521bad68f58c"), null, "Kiracı", "KIRACI" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9"), 0, "fba8e4da-0c2e-462e-845d-ce6855325493", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEPX2m57Ihd7Dv7EC8l6JxQgbQBdqzlbF7orzlB0s7TaogPAZDBdSq4cWrtCdroYAEA==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"), new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9") });

            migrationBuilder.CreateIndex(
                name: "IX_RegularlyPayUsers_InvoiceTypeId",
                table: "RegularlyPayUsers",
                column: "InvoiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularlyPayUsers_UserId",
                table: "RegularlyPayUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegularlyPayUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d261700f-6521-40db-89ae-521bad68f58c"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"), new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3007214e-f668-46b6-a608-cbb37cdd1ddc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1cb6011-b754-4147-a46a-a606ddaabea9"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5e8c7162-5d67-4ad3-9616-c7b0d94cbc57"), null, "Kiracı", "KIRACI" },
                    { new Guid("6947bdb8-c3ac-4c17-b973-0dea5914bf3c"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdentificationNumber", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("143fa954-1964-404b-b1ae-52536f240c95"), 0, "e104340b-d224-4cb7-9432-17c8d28980eb", "admin@admin.com", true, "11111111111", false, null, "Admin", "ADMIN@ADMIN.com", "ADMIN", "AQAAAAIAAYagAAAAEO8eo4jZ2CAFKkPxejDPXuQQ8YaT3phIoxtet3Aw1FNCJ+ZnzqcGhxT2U5w5Fo+B0A==", null, false, null, "ADMIN", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6947bdb8-c3ac-4c17-b973-0dea5914bf3c"), new Guid("143fa954-1964-404b-b1ae-52536f240c95") });
        }
    }
}
