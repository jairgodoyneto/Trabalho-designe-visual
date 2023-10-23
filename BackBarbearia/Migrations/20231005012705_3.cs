using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");

            migrationBuilder.DropIndex(
                name: "IX_Barbeiro_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");

            migrationBuilder.DropColumn(
                name: "UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");

            migrationBuilder.AddColumn<int>(
                name: "BarbeiroId",
                table: "UnidadeAtendimento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_BarbeiroId",
                table: "Barbeiro",
                column: "BarbeiroId",
                principalTable: "UnidadeAtendimento",
                principalColumn: "UnidadeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_BarbeiroId",
                table: "Barbeiro");

            migrationBuilder.DropColumn(
                name: "BarbeiroId",
                table: "UnidadeAtendimento");

            migrationBuilder.AddColumn<int>(
                name: "UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Barbeiro_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                column: "UnidadeAtendimentoUnidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                column: "UnidadeAtendimentoUnidadeId",
                principalTable: "UnidadeAtendimento",
                principalColumn: "UnidadeId");
        }
    }
}
