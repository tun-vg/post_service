using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Post.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCategoryToTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Tags",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CategoryId",
                table: "Tags",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Categories_CategoryId",
                table: "Tags",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Categories_CategoryId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CategoryId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Tags");
        }
    }
}
