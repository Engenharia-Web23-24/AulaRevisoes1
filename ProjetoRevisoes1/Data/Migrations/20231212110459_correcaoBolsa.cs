using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRevisoes1.Data.Migrations
{
    /// <inheritdoc />
    public partial class correcaoBolsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistadoEm",
                table: "Bolsas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistadoPor",
                table: "Bolsas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistadoEm",
                table: "Bolsas");

            migrationBuilder.DropColumn(
                name: "RegistadoPor",
                table: "Bolsas");
        }
    }
}
