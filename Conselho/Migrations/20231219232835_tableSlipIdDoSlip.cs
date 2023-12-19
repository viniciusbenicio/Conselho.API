using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conselho.API.Migrations
{
    /// <inheritdoc />
    public partial class tableSlipIdDoSlip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSlip",
                table: "Slip",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSlip",
                table: "Slip");
        }
    }
}
