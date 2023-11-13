using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Gerente",
                columns: table => new
                {
                    GerenteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerente", x => x.GerenteId);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Custo = table.Column<float>(type: "REAL", nullable: true),
                    Duracao = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.ServicoId);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true),
                    Cep = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.UnidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Barbeiro",
                columns: table => new
                {
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnidadeAtendimentoUnidadeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbeiro", x => x.BarbeiroId);
                    table.ForeignKey(
                        name: "FK_Barbeiro_UnidadeAtendimento_UnidadeAtendimentoUnidadeId",
                        column: x => x.UnidadeAtendimentoUnidadeId,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "UnidadeId");
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: true),
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.AgendaId);
                    table.ForeignKey(
                        name: "FK_Agenda_Barbeiro_BarbeiroId",
                        column: x => x.BarbeiroId,
                        principalTable: "Barbeiro",
                        principalColumn: "BarbeiroId");
                    table.ForeignKey(
                        name: "FK_Agenda_UnidadeAtendimento_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "UnidadeId");
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: true),
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: true),
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Horario = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.AtendimentoId);
                    table.ForeignKey(
                        name: "FK_Atendimento_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "AgendaId");
                    table.ForeignKey(
                        name: "FK_Atendimento_Barbeiro_BarbeiroId",
                        column: x => x.BarbeiroId,
                        principalTable: "Barbeiro",
                        principalColumn: "BarbeiroId");
                    table.ForeignKey(
                        name: "FK_Atendimento_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId");
                    table.ForeignKey(
                        name: "FK_Atendimento_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_BarbeiroId",
                table: "Agenda",
                column: "BarbeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_UnidadeId",
                table: "Agenda",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_AgendaId",
                table: "Atendimento",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_BarbeiroId",
                table: "Atendimento",
                column: "BarbeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ClienteId",
                table: "Atendimento",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ServicoId",
                table: "Atendimento",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Barbeiro_UnidadeAtendimentoUnidadeId",
                table: "Barbeiro",
                column: "UnidadeAtendimentoUnidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Gerente");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Barbeiro");

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");
        }
    }
}
