using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conselho.API.Migrations
{
    /// <inheritdoc />
    public partial class Colunadetextoparasalvaroconselhotestesiniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Conselho",
                table: "Usuario",
                type: "NVARCHAR(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conselho",
                table: "Usuario");
        }
    }
}
