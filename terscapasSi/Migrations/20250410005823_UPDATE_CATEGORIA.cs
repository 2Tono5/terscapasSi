using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace terscapasSi.Migrations
{
    /// <inheritdoc />
    public partial class UPDATE_CATEGORIA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categoria",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Categoria");
        }
    }
}
