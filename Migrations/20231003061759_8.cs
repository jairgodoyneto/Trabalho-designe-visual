using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BarbeiroId",
                table: "Barbeiro",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Enderco = table.Column<string>(type: "TEXT", nullable: false),
                    Cep = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.UnidadeId);
                });

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

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");

            migrationBuilder.AlterColumn<int>(
                name: "BarbeiroId",
                table: "Barbeiro",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
