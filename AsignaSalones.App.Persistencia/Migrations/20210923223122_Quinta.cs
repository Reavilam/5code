using Microsoft.EntityFrameworkCore.Migrations;

namespace AsignaSalones.App.Persistencia.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estudianteid = table.Column<int>(type: "int", nullable: true),
                    clase_1id = table.Column<int>(type: "int", nullable: true),
                    clase_2id = table.Column<int>(type: "int", nullable: true),
                    clase_3id = table.Column<int>(type: "int", nullable: true),
                    clase_4id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Matriculas_HorariosClases_clase_1id",
                        column: x => x.clase_1id,
                        principalTable: "HorariosClases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_HorariosClases_clase_2id",
                        column: x => x.clase_2id,
                        principalTable: "HorariosClases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_HorariosClases_clase_3id",
                        column: x => x.clase_3id,
                        principalTable: "HorariosClases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_HorariosClases_clase_4id",
                        column: x => x.clase_4id,
                        principalTable: "HorariosClases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Personas_estudianteid",
                        column: x => x.estudianteid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_clase_1id",
                table: "Matriculas",
                column: "clase_1id");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_clase_2id",
                table: "Matriculas",
                column: "clase_2id");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_clase_3id",
                table: "Matriculas",
                column: "clase_3id");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_clase_4id",
                table: "Matriculas",
                column: "clase_4id");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_estudianteid",
                table: "Matriculas",
                column: "estudianteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matriculas");
        }
    }
}
