using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandLord.Migrations
{
    /// <inheritdoc />
    public partial class RenameStringInComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Comments",
                newName: "Comment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Comments",
                newName: "Description");
        }
    }
}