using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Enderco",
                table: "UnidadeAtendimento",
                newName: "Endereco");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Barbeiro",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Barbeiro");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "UnidadeAtendimento",
                newName: "Enderco");
        }
    }
}
