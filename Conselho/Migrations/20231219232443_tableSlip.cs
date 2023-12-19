using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conselho.API.Migrations
{
    /// <inheritdoc />
    public partial class tableSlip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conselho",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "Slip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slip", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slip");

            migrationBuilder.AddColumn<string>(
                name: "Conselho",
                table: "Usuario",
                type: "NVARCHAR(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
