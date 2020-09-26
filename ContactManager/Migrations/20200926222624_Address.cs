using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManager.Migrations
{
    public partial class Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: false),
                    LineTwo = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "LineTwo", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Hidden Leaf Village", null, "Land of Fire", "456 Orphan Ave", 12345 },
                    { 2, "Hidden Leaf Village", null, "Land of Fire", "123 Hidden Leaf Way", 12345 }
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 9, 26, 17, 26, 24, 531, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 9, 26, 17, 26, 24, 534, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 9, 26, 17, 26, 24, 534, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "AddressId", "CategoryId", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "Phone" },
                values: new object[] { 4, 1, 2, new DateTime(2020, 9, 26, 17, 26, 24, 534, DateTimeKind.Local).AddTicks(2482), "believeit@gmail.com", "Naruto", "Uzumaki", null, "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "AddressId", "CategoryId", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "Phone" },
                values: new object[] { 5, 2, 2, new DateTime(2020, 9, 26, 17, 26, 24, 534, DateTimeKind.Local).AddTicks(2674), "angtsy-boi@gmail.com", "Sasuke", "Uchiha", null, "098-765-4321" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 9, 26, 17, 19, 54, 295, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 9, 26, 17, 19, 54, 298, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 9, 26, 17, 19, 54, 298, DateTimeKind.Local).AddTicks(1054));
        }
    }
}
