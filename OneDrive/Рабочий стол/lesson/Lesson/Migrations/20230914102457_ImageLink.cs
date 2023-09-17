using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson.Migrations
{
    /// <inheritdoc />
    public partial class ImageLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Phones",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Phones");
        }
    }
}
