using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class atualização : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");

            migrationBuilder.RenameColumn(
                name: "UnidadeId",
                table: "UnidadeAtendimento",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                newName: "UnidadeAtendimentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Barbeiro_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                newName: "IX_Barbeiro_UnidadeAtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoId",
                table: "Barbeiro",
                column: "UnidadeAtendimentoId",
                principalTable: "UnidadeAtendimento",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoId",
                table: "Barbeiro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UnidadeAtendimento",
                newName: "UnidadeId");

            migrationBuilder.RenameColumn(
                name: "UnidadeAtendimentoId",
                table: "Barbeiro",
                newName: "UnidadeAtendimentoUnidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Barbeiro_UnidadeAtendimentoId",
                table: "Barbeiro",
                newName: "IX_Barbeiro_UnidadeAtendimentoUnidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                column: "UnidadeAtendimentoUnidadeId",
                principalTable: "UnidadeAtendimento",
                principalColumn: "UnidadeId");
        }
    }
}
