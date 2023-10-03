using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Barbeiro",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Barbeiro");
        }
    }
}
