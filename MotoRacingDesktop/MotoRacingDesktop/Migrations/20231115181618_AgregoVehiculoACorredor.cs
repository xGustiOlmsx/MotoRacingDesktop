using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoRacingDesktop.Migrations
{
    /// <inheritdoc />
    public partial class AgregoVehiculoACorredor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Corredores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Corredores_VehiculoId",
                table: "Corredores",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Corredores_Vehiculos_VehiculoId",
                table: "Corredores",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corredores_Vehiculos_VehiculoId",
                table: "Corredores");

            migrationBuilder.DropIndex(
                name: "IX_Corredores_VehiculoId",
                table: "Corredores");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Corredores");
        }
    }
}
