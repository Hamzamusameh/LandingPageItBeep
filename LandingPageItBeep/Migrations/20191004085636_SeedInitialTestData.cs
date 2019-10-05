using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LandingPageItBeep.Migrations
{
    public partial class SeedInitialTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Lookups",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "LookupID", "CraetedBy", "CreatedDate", "IsDeleted", "LookupName", "LookupNameEn" },
                values: new object[] { 1, 1, new DateTime(2019, 10, 4, 11, 56, 35, 886, DateTimeKind.Local).AddTicks(9297), false, "العروض", "Offers" });

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "LookupID", "CraetedBy", "CreatedDate", "IsDeleted", "LookupName", "LookupNameEn" },
                values: new object[] { 2, 1, new DateTime(2019, 10, 4, 11, 56, 35, 892, DateTimeKind.Local).AddTicks(8901), false, "وقت الطلب", "Order Time" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "LookupID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "LookupID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Lookups");
        }
    }
}
