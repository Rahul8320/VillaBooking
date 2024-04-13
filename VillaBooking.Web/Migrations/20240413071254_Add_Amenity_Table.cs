using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaBooking.Web.Migrations
{
    /// <inheritdoc />
    public partial class Add_Amenity_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2594), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2602), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2606), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2615), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 303,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2619), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2208), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2215), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 3, 9, 15, 39, 31, 593, DateTimeKind.Utc).AddTicks(2221) });
        }
    }
}
