﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salao.Migrations
{
    /// <inheritdoc />
    public partial class AtendimentoAgendado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Servico_id",
                table: "AtendimentoAgendado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Servico_id",
                table: "AtendimentoAgendado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
