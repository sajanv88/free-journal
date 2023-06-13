using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPostcolumnpublishedanddraft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDraft",
                table: "posts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "posts",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDraft",
                table: "posts");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "posts");
        }
    }
}
