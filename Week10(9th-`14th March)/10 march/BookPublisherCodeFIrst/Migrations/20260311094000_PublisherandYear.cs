using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookPublisherCodeFIrst.Migrations
{
    /// <inheritdoc />
    public partial class PublisherandYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublishedYear",
                table: "tblBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "tblBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishedYear",
                table: "tblBooks");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "tblBooks");
        }
    }
}
