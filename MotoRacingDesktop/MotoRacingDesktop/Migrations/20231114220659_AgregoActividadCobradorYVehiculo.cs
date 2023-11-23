using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MotoRacingDesktop.Migrations
{
    /// <inheritdoc />
    public partial class AgregoActividadCobradorYVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Horarios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cobradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cobrada = table.Column<bool>(type: "bit", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActividadId = table.Column<int>(type: "int", nullable: false),
                    CorredorId = table.Column<int>(type: "int", nullable: false),
                    CobradorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuotas_Actividades_ActividadId",
                        column: x => x.ActividadId,
                        principalTable: "Actividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cuotas_Cobradores_CobradorId",
                        column: x => x.CobradorId,
                        principalTable: "Cobradores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cuotas_Corredores_CorredorId",
                        column: x => x.CorredorId,
                        principalTable: "Corredores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actividades",
                columns: new[] { "Id", "Costo", "Horarios", "Nombre" },
                values: new object[,]
                {
                    { 1, 25000m, "Lunes y miércoles 20hs", "Moto GP" },
                    { 2, 25000m, "Martes y Jueves 20hs", "Moto Cross" },
                    { 3, 20000m, "Lunes y miércoles 16hs", "Karting GP" },
                    { 4, 20000m, "Martes y Jueves 16hs", "Moto Enduro" }
                });

            migrationBuilder.InsertData(
                table: "Cobradores",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Rodrigo Palacio" });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Moto Deportiva" },
                    { 2, "Moto Cross" },
                    { 3, "Karting" },
                    { 4, "Moto Enduro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_ActividadId",
                table: "Cuotas",
                column: "ActividadId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_CobradorId",
                table: "Cuotas",
                column: "CobradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_CorredorId",
                table: "Cuotas",
                column: "CorredorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuotas");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Cobradores");
        }
    }
}
