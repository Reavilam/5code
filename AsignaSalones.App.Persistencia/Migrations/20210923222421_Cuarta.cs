using Microsoft.EntityFrameworkCore.Migrations;

namespace AsignaSalones.App.Persistencia.Migrations
{
    public partial class Cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorarioClase_Personas_profesorid",
                table: "HorarioClase");

            migrationBuilder.DropForeignKey(
                name: "FK_HorarioClase_Salones_salonAsignadoid",
                table: "HorarioClase");

            migrationBuilder.DropForeignKey(
                name: "FK_HorarioClase_SedesUniversidad_SedeUniversidadid",
                table: "HorarioClase");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_HorarioClase_HorarioClaseid",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_HorarioClaseid",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HorarioClase",
                table: "HorarioClase");

            migrationBuilder.DropColumn(
                name: "HorarioClaseid",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "HorarioClase",
                newName: "HorariosClases");

            migrationBuilder.RenameIndex(
                name: "IX_HorarioClase_SedeUniversidadid",
                table: "HorariosClases",
                newName: "IX_HorariosClases_SedeUniversidadid");

            migrationBuilder.RenameIndex(
                name: "IX_HorarioClase_salonAsignadoid",
                table: "HorariosClases",
                newName: "IX_HorariosClases_salonAsignadoid");

            migrationBuilder.RenameIndex(
                name: "IX_HorarioClase_profesorid",
                table: "HorariosClases",
                newName: "IX_HorariosClases_profesorid");

            migrationBuilder.AlterColumn<string>(
                name: "identificacion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HorariosClases",
                table: "HorariosClases",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_HorariosClases_Personas_profesorid",
                table: "HorariosClases",
                column: "profesorid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HorariosClases_Salones_salonAsignadoid",
                table: "HorariosClases",
                column: "salonAsignadoid",
                principalTable: "Salones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HorariosClases_SedesUniversidad_SedeUniversidadid",
                table: "HorariosClases",
                column: "SedeUniversidadid",
                principalTable: "SedesUniversidad",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorariosClases_Personas_profesorid",
                table: "HorariosClases");

            migrationBuilder.DropForeignKey(
                name: "FK_HorariosClases_Salones_salonAsignadoid",
                table: "HorariosClases");

            migrationBuilder.DropForeignKey(
                name: "FK_HorariosClases_SedesUniversidad_SedeUniversidadid",
                table: "HorariosClases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HorariosClases",
                table: "HorariosClases");

            migrationBuilder.RenameTable(
                name: "HorariosClases",
                newName: "HorarioClase");

            migrationBuilder.RenameIndex(
                name: "IX_HorariosClases_SedeUniversidadid",
                table: "HorarioClase",
                newName: "IX_HorarioClase_SedeUniversidadid");

            migrationBuilder.RenameIndex(
                name: "IX_HorariosClases_salonAsignadoid",
                table: "HorarioClase",
                newName: "IX_HorarioClase_salonAsignadoid");

            migrationBuilder.RenameIndex(
                name: "IX_HorariosClases_profesorid",
                table: "HorarioClase",
                newName: "IX_HorarioClase_profesorid");

            migrationBuilder.AlterColumn<int>(
                name: "identificacion",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorarioClaseid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HorarioClase",
                table: "HorarioClase",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HorarioClaseid",
                table: "Personas",
                column: "HorarioClaseid");

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioClase_Personas_profesorid",
                table: "HorarioClase",
                column: "profesorid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioClase_Salones_salonAsignadoid",
                table: "HorarioClase",
                column: "salonAsignadoid",
                principalTable: "Salones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioClase_SedesUniversidad_SedeUniversidadid",
                table: "HorarioClase",
                column: "SedeUniversidadid",
                principalTable: "SedesUniversidad",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_HorarioClase_HorarioClaseid",
                table: "Personas",
                column: "HorarioClaseid",
                principalTable: "HorarioClase",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
