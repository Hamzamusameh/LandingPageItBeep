using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LandingPageItBeep.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LookupCategory",
                nullable: true);

            migrationBuilder.InsertData(
                table: "LookupCategory",
                columns: new[] { "LookupCategoryID", "CraetedBy", "CreatedDate", "IsDeleted", "LookupID", "LookupName", "LookupNameEn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 10, 4, 12, 18, 41, 958, DateTimeKind.Local).AddTicks(52), false, 1, "عرض 1", "Offer 1" },
                    { 2, 1, new DateTime(2019, 10, 4, 12, 18, 41, 958, DateTimeKind.Local).AddTicks(6267), false, 1, "عرض 2", "Offer 2" },
                    { 3, 1, new DateTime(2019, 10, 4, 12, 18, 41, 958, DateTimeKind.Local).AddTicks(6311), false, 1, "عرض 3", "Offer 3" },
                    { 4, 1, new DateTime(2019, 10, 4, 12, 18, 41, 958, DateTimeKind.Local).AddTicks(6316), false, 2, "استفسار عام", "General Inquiry" },
                    { 5, 1, new DateTime(2019, 10, 4, 12, 18, 41, 958, DateTimeKind.Local).AddTicks(6321), false, 2, "خلال شهر", "During Months" },
                    { 6, 1, new DateTime(2019, 10, 4, 12, 18, 41, 958, DateTimeKind.Local).AddTicks(6326), false, 2, "خلال اسبوع", "During Week" }
                });

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "LookupID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 4, 12, 18, 41, 936, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "LookupID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 4, 12, 18, 41, 957, DateTimeKind.Local).AddTicks(4933));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "LookupCategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "LookupCategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "LookupCategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "LookupCategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "LookupCategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LookupCategory",
                keyColumn: "LookupCategoryID",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LookupCategory");

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "LookupID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 4, 11, 56, 35, 886, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "LookupID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 4, 11, 56, 35, 892, DateTimeKind.Local).AddTicks(8901));
        }
    }
}
