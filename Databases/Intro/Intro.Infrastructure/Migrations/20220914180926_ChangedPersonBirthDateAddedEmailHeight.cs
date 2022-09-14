using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intro.Infrastructure.Migrations
{
    public partial class ChangedPersonBirthDateAddedEmailHeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "People",
                newName: "Height");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "People",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "People",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "People",
                newName: "Age");
        }
    }
}
