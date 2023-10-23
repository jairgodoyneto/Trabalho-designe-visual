using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    Cep = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.UnidadeId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");

            migrationBuilder.DropIndex(
                name: "IX_Barbeiro_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");

            migrationBuilder.DropColumn(
                name: "UnidadeAtendimentoUnidadeId",
                table: "Barbeiro");
        }
    }
}
