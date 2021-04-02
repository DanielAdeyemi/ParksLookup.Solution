using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkName = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false),
                    ParkLocation = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    National = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Local = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Local", "National", "ParkLocation", "ParkName" },
                values: new object[,]
                {
                    { 1, true, false, "Portland, OR", "Buike" },
                    { 2, false, true, "Sierra Nevada, CA", "Yosemite" },
                    { 3, true, false, "Denver, CO", "LakeView" },
                    { 4, false, true, "Arizona", "Grand Canyon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
