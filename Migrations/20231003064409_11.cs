using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Barbeiro");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Barbeiro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Barbeiro",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Barbeiro",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
