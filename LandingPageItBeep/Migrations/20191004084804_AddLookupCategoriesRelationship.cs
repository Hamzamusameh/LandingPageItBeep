using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LandingPageItBeep.Migrations
{
    public partial class AddLookupCategoriesRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookupCategory",
                columns: table => new
                {
                    LookupCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LookupID = table.Column<int>(nullable: false),
                    LookupName = table.Column<string>(nullable: true),
                    LookupNameEn = table.Column<string>(nullable: true),
                    CraetedBy = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupCategory", x => x.LookupCategoryID);
                    table.ForeignKey(
                        name: "FK_LookupCategory_Lookups_LookupID",
                        column: x => x.LookupID,
                        principalTable: "Lookups",
                        principalColumn: "LookupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LookupCategory_LookupID",
                table: "LookupCategory",
                column: "LookupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LookupCategory");
        }
    }
}
