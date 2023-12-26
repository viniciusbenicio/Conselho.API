using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conselho.API.Migrations
{
    /// <inheritdoc />
    public partial class DeletarUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Usuarios",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Spli_Results",
                table: "Slip");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Usuarios",
                table: "Emails",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spli_Results",
                table: "Slip",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Usuarios",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Spli_Results",
                table: "Slip");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Usuarios",
                table: "Emails",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spli_Results",
                table: "Slip",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }
    }
}
