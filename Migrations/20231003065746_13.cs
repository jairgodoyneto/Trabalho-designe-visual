using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtendimentoAvulsoId",
                table: "AtendimentoAvulso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AtendimentoAvulsoId",
                table: "AtendimentoAvulso",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
