using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class _25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Atendimento_AtendimentoId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAvulso_Atendimento_AtendimentoId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.AlterColumn<int>(
                name: "AtendimentoId",
                table: "AtendimentoAvulso",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "BarbeiroId",
                table: "AtendimentoAvulso",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "AtendimentoAvulso",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "AtendimentoAvulso",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AtendimentoId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "BarbeiroId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "AtendimentoAgendado",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAvulso_BarbeiroId",
                table: "AtendimentoAvulso",
                column: "BarbeiroId");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoAvulso_ServicoId",
                table: "AtendimentoAvulso",
                column: "ServicoId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAvulso_Barbeiro_BarbeiroId",
                table: "AtendimentoAvulso",
                column: "BarbeiroId",
                principalTable: "Barbeiro",
                principalColumn: "BarbeiroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAvulso_Servico_ServicoId",
                table: "AtendimentoAvulso",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Barbeiro_BarbeiroId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAgendado_Servico_ServicoId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAvulso_Barbeiro_BarbeiroId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropForeignKey(
                name: "FK_AtendimentoAvulso_Servico_ServicoId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAvulso_BarbeiroId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAvulso_ServicoId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAgendado_BarbeiroId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropIndex(
                name: "IX_AtendimentoAgendado_ServicoId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropColumn(
                name: "BarbeiroId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "AtendimentoAvulso");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "AtendimentoAvulso");

            migrationBuilder.DropColumn(
                name: "BarbeiroId",
                table: "AtendimentoAgendado");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "AtendimentoAgendado");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "AtendimentoAgendado");

            migrationBuilder.AlterColumn<int>(
                name: "AtendimentoId",
                table: "AtendimentoAvulso",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "AtendimentoId",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.AgendaId);
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
                    AtendimentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    BarbeiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.AtendimentoId);
                    table.ForeignKey(
                        name: "FK_Atendimento_Agenda_AtendimentoId",
                        column: x => x.AtendimentoId,
                        principalTable: "Agenda",
                        principalColumn: "AgendaId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    DateId = table.Column<int>(type: "INTEGER", nullable: false),
                    Dia = table.Column<int>(type: "INTEGER", nullable: false),
                    Tempo = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.DateId);
                    table.ForeignKey(
                        name: "FK_Date_Agenda_DateId",
                        column: x => x.DateId,
                        principalTable: "Agenda",
                        principalColumn: "AgendaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_UnidadeId",
                table: "Agenda",
                column: "UnidadeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AtendimentoAvulso_Atendimento_AtendimentoId",
                table: "AtendimentoAvulso",
                column: "AtendimentoId",
                principalTable: "Atendimento",
                principalColumn: "AtendimentoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
