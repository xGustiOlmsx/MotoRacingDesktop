using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoRacingDesktop.Migrations
{
    /// <inheritdoc />
    public partial class agregoActividadACorredor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Corredores_CorredorId",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_CorredorId",
                table: "Actividades");

            migrationBuilder.AddColumn<int>(
                name: "ActividadId",
                table: "Corredores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PistaId",
                table: "Actividades",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 1,
                column: "PistaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 2,
                column: "PistaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 3,
                column: "PistaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 4,
                column: "PistaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Corredores_ActividadId",
                table: "Corredores",
                column: "ActividadId",
                unique: true,
                filter: "[ActividadId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_PistaId",
                table: "Actividades",
                column: "PistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Pistas_PistaId",
                table: "Actividades",
                column: "PistaId",
                principalTable: "Pistas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Corredores_Actividades_ActividadId",
                table: "Corredores",
                column: "ActividadId",
                principalTable: "Actividades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Pistas_PistaId",
                table: "Actividades");

            migrationBuilder.DropForeignKey(
                name: "FK_Corredores_Actividades_ActividadId",
                table: "Corredores");

            migrationBuilder.DropIndex(
                name: "IX_Corredores_ActividadId",
                table: "Corredores");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_PistaId",
                table: "Actividades");

            migrationBuilder.DropColumn(
                name: "ActividadId",
                table: "Corredores");

            migrationBuilder.DropColumn(
                name: "PistaId",
                table: "Actividades");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_CorredorId",
                table: "Actividades",
                column: "CorredorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Corredores_CorredorId",
                table: "Actividades",
                column: "CorredorId",
                principalTable: "Corredores",
                principalColumn: "Id");
        }
    }
}
