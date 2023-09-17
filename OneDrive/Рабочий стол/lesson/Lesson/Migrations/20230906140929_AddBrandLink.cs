using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Phones");

            migrationBuilder.AddColumn<long>(
                name: "BrandId",
                table: "Phones",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phones_BrandId",
                table: "Phones",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Brands_BrandId",
                table: "Phones",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Brands_BrandId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_BrandId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Phones");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Phones",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
