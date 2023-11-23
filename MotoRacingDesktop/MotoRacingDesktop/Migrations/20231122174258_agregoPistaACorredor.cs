using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotoRacingDesktop.Migrations
{
    /// <inheritdoc />
    public partial class agregoPistaACorredor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PistaId",
                table: "Corredores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pistas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corredores_PistaId",
                table: "Corredores",
                column: "PistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Corredores_Pistas_PistaId",
                table: "Corredores",
                column: "PistaId",
                principalTable: "Pistas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corredores_Pistas_PistaId",
                table: "Corredores");

            migrationBuilder.DropTable(
                name: "Pistas");

            migrationBuilder.DropIndex(
                name: "IX_Corredores_PistaId",
                table: "Corredores");

            migrationBuilder.DropColumn(
                name: "PistaId",
                table: "Corredores");
        }
    }
}
