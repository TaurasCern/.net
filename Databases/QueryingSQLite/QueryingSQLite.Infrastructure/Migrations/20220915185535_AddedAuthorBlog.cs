using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueryingSQLite.Infrastructure.Migrations
{
    public partial class AddedAuthorBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AthorBlogs_Author_AuthorId",
                table: "AthorBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_AthorBlogs_Blog_BlogId",
                table: "AthorBlogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AthorBlogs",
                table: "AthorBlogs");

            migrationBuilder.RenameTable(
                name: "AthorBlogs",
                newName: "AuthorBlogs");

            migrationBuilder.RenameIndex(
                name: "IX_AthorBlogs_BlogId",
                table: "AuthorBlogs",
                newName: "IX_AuthorBlogs_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorBlogs",
                table: "AuthorBlogs",
                columns: new[] { "AuthorId", "BlogId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBlogs_Author_AuthorId",
                table: "AuthorBlogs",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBlogs_Blog_BlogId",
                table: "AuthorBlogs",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBlogs_Author_AuthorId",
                table: "AuthorBlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBlogs_Blog_BlogId",
                table: "AuthorBlogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorBlogs",
                table: "AuthorBlogs");

            migrationBuilder.RenameTable(
                name: "AuthorBlogs",
                newName: "AthorBlogs");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBlogs_BlogId",
                table: "AthorBlogs",
                newName: "IX_AthorBlogs_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AthorBlogs",
                table: "AthorBlogs",
                columns: new[] { "AuthorId", "BlogId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AthorBlogs_Author_AuthorId",
                table: "AthorBlogs",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AthorBlogs_Blog_BlogId",
                table: "AthorBlogs",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
