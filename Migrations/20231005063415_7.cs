using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Barbeiro_BarbeiroId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Servico_ServicoId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAgendado_BarbeiroId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAgendado_ServicoId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Gerente");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Barbeiro");

            migrationBuilder.DropColumn(
                name: "BarbeiroId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "AtendimentoAgendado");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "AtendimentoAgendado",
                newName: "Horario");

            migrationBuilder.AddColumn<int>(
                name: "Duracao",
                table: "Servico",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.AgendaId);
                    table.ForeignKey(
                        name: "FK_Agenda_Barbeiro_BarbeiroId",
                        column: x => x.BarbeiroId,
                        principalTable: "Barbeiro",
                        principalColumn: "BarbeiroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agenda_UnidadeAtendimento_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: true)
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
                        principalColumn: "BarbeiroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimento_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Atendimento_ServicoId",
                table: "Atendimento",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAgendado_Atendimento_AtendimentoId",
                table: "AtendimentoAgendado",
                column: "AtendimentoId",
                principalTable: "Atendimento",
                principalColumn: "AtendimentoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Atendimento_AtendimentoId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Servico");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "AtendimentoAgendado",
                newName: "Data");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Gerente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Cliente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Barbeiro",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BarbeiroId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_BarbeiroId",
                table: "AtendimentoAgendado",
                column: "BarbeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_ServicoId",
                table: "AtendimentoAgendado",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAgendado_Barbeiro_BarbeiroId",
                table: "AtendimentoAgendado",
                column: "BarbeiroId",
                principalTable: "Barbeiro",
                principalColumn: "BarbeiroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAgendado_Servico_ServicoId",
                table: "AtendimentoAgendado",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
