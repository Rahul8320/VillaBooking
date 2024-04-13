using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaBooking.Web.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Data_To_Amenity_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    VillaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amenities_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "CreatedDateTime", "Description", "Name", "UpdatedDateTime", "VillaId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Private Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Microwave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Private Balcony", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ac & TV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Private Plunge Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Microwave and Mini Refrigator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Private Balcony", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "King bed or 2 double beds", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Private Pool & Private Balcony", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jacuzzi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Microwave & Refrigator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7270), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7271), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7273), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7275), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7276), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7277), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 303,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7179), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7182), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7184), new DateTime(2024, 4, 13, 7, 28, 12, 52, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_VillaId",
                table: "Amenities",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(116), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(119), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(122), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(123), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 303,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(126), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(38), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(41), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 4, 13, 7, 12, 54, 342, DateTimeKind.Utc).AddTicks(44) });
        }
    }
}
