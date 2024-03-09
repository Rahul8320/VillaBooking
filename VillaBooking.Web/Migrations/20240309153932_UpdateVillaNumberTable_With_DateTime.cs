using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaBooking.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVillaNumberTable_With_DateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "VillaNumbers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "VillaNumbers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "UpdatedDateTime",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 18, 22, 661, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 3, 9, 15, 18, 22, 661, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 18, 22, 661, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 3, 9, 15, 18, 22, 661, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 18, 22, 661, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 3, 9, 15, 18, 22, 661, DateTimeKind.Utc).AddTicks(2756) });
        }
    }
}
