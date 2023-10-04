using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class tirartudoestrageira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_BarbeiroId",
                table: "Barbeiro");

            migrationBuilder.DropTable(
                name: "AtendimentoAgendado");

            migrationBuilder.DropTable(
                name: "AtendimentoAvulso");

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtendimentoAgendado",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtendimentoAgendado", x => x.AtendimentoId);
                    table.ForeignKey(
                        name: "FK_AtendimentoAgendado_Barbeiro_BarbeiroId",
                        column: x => x.BarbeiroId,
                        principalTable: "Barbeiro",
                        principalColumn: "BarbeiroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtendimentoAgendado_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtendimentoAgendado_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtendimentoAvulso",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtendimentoAvulso", x => x.AtendimentoId);
                    table.ForeignKey(
                        name: "FK_AtendimentoAvulso_Barbeiro_BarbeiroId",
                        column: x => x.BarbeiroId,
                        principalTable: "Barbeiro",
                        principalColumn: "BarbeiroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtendimentoAvulso_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cep = table.Column<int>(type: "INTEGER", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.UnidadeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_BarbeiroId",
                table: "AtendimentoAgendado",
                column: "BarbeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_ClienteId",
                table: "AtendimentoAgendado",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_ServicoId",
                table: "AtendimentoAgendado",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAvulso_BarbeiroId",
                table: "AtendimentoAvulso",
                column: "BarbeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAvulso_ServicoId",
                table: "AtendimentoAvulso",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Barbeiro_UnidadeAtendimento_BarbeiroId",
                table: "Barbeiro",
                column: "BarbeiroId",
                principalTable: "UnidadeAtendimento",
                principalColumn: "UnidadeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
