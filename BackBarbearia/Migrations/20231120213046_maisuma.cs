using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class maisuma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Agenda_AgendaId",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Barbeiro_BarbeiroId",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Servico_ServicoId",
                table: "Atendimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atendimento",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_AgendaId",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_BarbeiroId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "BarbeiroId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Atendimento");

            migrationBuilder.RenameTable(
                name: "Atendimento",
                newName: "AtendimentoAvulso");

            migrationBuilder.RenameIndex(
                name: "IX_Atendimento_ServicoId",
                table: "AtendimentoAvulso",
                newName: "IX_AtendimentoAvulso_ServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Atendimento_ClienteId",
                table: "AtendimentoAvulso",
                newName: "IX_AtendimentoAvulso_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtendimentoAvulso",
                table: "AtendimentoAvulso",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AtendimentoAgendado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Horario = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: true),
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtendimentoAgendado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtendimentoAgendado_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AtendimentoAgendado_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtendimentoAgendado_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_AgendaId",
                table: "AtendimentoAgendado",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_ClienteId",
                table: "AtendimentoAgendado",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAgendado_ServicoId",
                table: "AtendimentoAgendado",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAvulso_Cliente_ClienteId",
                table: "AtendimentoAvulso",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAvulso_Servico_ServicoId",
                table: "AtendimentoAvulso",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAvulso_Cliente_ClienteId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAvulso_Servico_ServicoId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropTable(
                name: "AtendimentoAgendado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtendimentoAvulso",
                table: "AtendimentoAvulso");

            migrationBuilder.RenameTable(
                name: "AtendimentoAvulso",
                newName: "Atendimento");

            migrationBuilder.RenameIndex(
                name: "IX_AtendimentoAvulso_ServicoId",
                table: "Atendimento",
                newName: "IX_Atendimento_ServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_AtendimentoAvulso_ClienteId",
                table: "Atendimento",
                newName: "IX_Atendimento_ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Atendimento",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BarbeiroId",
                table: "Atendimento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Atendimento",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Horario",
                table: "Atendimento",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atendimento",
                table: "Atendimento",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_AgendaId",
                table: "Atendimento",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_BarbeiroId",
                table: "Atendimento",
                column: "BarbeiroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Agenda_AgendaId",
                table: "Atendimento",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Barbeiro_BarbeiroId",
                table: "Atendimento",
                column: "BarbeiroId",
                principalTable: "Barbeiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId",
                table: "Atendimento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Servico_ServicoId",
                table: "Atendimento",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
