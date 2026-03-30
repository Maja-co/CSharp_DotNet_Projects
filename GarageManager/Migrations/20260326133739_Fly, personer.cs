using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageManager.Migrations
{
    /// <inheritdoc />
    public partial class Flypersoner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flyvemaskiner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelNavn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flyvemaskiner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlyPerson",
                columns: table => new
                {
                    EjereId = table.Column<int>(type: "int", nullable: false),
                    FlyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlyPerson", x => new { x.EjereId, x.FlyId });
                    table.ForeignKey(
                        name: "FK_FlyPerson_Flyvemaskiner_FlyId",
                        column: x => x.FlyId,
                        principalTable: "Flyvemaskiner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlyPerson_Personer_EjereId",
                        column: x => x.EjereId,
                        principalTable: "Personer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlyPerson_FlyId",
                table: "FlyPerson",
                column: "FlyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlyPerson");

            migrationBuilder.DropTable(
                name: "Flyvemaskiner");

            migrationBuilder.DropTable(
                name: "Personer");
        }
    }
}
