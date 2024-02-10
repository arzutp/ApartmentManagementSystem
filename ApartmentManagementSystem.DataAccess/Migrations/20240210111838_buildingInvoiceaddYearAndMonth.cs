using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentManagementSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class buildingInvoiceaddYearAndMonth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "BuildingInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "BuildingInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Month",
                table: "BuildingInvoices");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "BuildingInvoices");

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
        }
    }
}
