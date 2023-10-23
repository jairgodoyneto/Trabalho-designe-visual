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
            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Cliente_ClienteId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAgendado_ClienteId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "AtendimentoAgendado");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Atendimento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ClienteId",
                table: "Atendimento",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId",
                table: "Atendimento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_ClienteId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Atendimento");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_ClienteId",
                table: "AtendimentoAgendado",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAgendado_Cliente_ClienteId",
                table: "AtendimentoAgendado",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
