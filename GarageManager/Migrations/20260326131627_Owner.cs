using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageManager.Migrations
{
    /// <inheritdoc />
    public partial class Owner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EjerId",
                table: "Biler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ejere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejere", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biler_EjerId",
                table: "Biler",
                column: "EjerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biler_Ejere_EjerId",
                table: "Biler",
                column: "EjerId",
                principalTable: "Ejere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biler_Ejere_EjerId",
                table: "Biler");

            migrationBuilder.DropTable(
                name: "Ejere");

            migrationBuilder.DropIndex(
                name: "IX_Biler_EjerId",
                table: "Biler");

            migrationBuilder.DropColumn(
                name: "EjerId",
                table: "Biler");
        }
    }
}
