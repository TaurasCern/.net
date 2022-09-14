using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intro.Infrastructure.Migrations
{
    public partial class AddedPersonWeightBiography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "People",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "People",
                type: "REAL",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "People");
        }
    }
}
