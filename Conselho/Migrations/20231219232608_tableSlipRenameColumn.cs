using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conselho.API.Migrations
{
    /// <inheritdoc />
    public partial class tableSlipRenameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Slip",
                newName: "Descricao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Slip",
                newName: "Nome");
        }
    }
}
