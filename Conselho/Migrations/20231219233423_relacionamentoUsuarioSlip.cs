using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conselho.API.Migrations
{
    /// <inheritdoc />
    public partial class relacionamentoUsuarioSlip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Slip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Slip_UsuarioId",
                table: "Slip",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spli_Results",
                table: "Slip",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spli_Results",
                table: "Slip");

            migrationBuilder.DropIndex(
                name: "IX_Slip_UsuarioId",
                table: "Slip");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Slip");
        }
    }
}
