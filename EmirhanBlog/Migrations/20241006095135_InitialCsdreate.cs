using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmirhanBlog.Migrations
{
    /// <inheritdoc />
    public partial class InitialCsdreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Author_AuthorId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Blog_CategoryId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_AuthorId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Blog",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "Blog",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AuthorId",
                table: "Blog",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Author_AuthorId",
                table: "Blog",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Category_CategoryId",
                table: "Blog",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Author_AuthorId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Category_CategoryId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_AuthorId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blog",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_AuthorId",
                table: "Category",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryId",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Author_AuthorId",
                table: "Category",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Blog_CategoryId",
                table: "Category",
                column: "CategoryId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
