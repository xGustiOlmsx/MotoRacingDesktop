using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoRacingDesktop.Migrations
{
    /// <inheritdoc />
    public partial class agregoCorredorAActividad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorredorId",
                table: "Actividades",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CorredorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CorredorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CorredorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actividades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CorredorId",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Corredores_CorredorId",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_CorredorId",
                table: "Actividades");

            migrationBuilder.DropColumn(
                name: "CorredorId",
                table: "Actividades");
        }
    }
}
