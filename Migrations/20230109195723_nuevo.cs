using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba2.Migrations
{
    /// <inheritdoc />
    public partial class nuevo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Sede_SedeId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Sede_SedeId",
                table: "Usuarios",
                column: "SedeId",
                principalTable: "Sede",
                principalColumn: "SedeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Sede_SedeId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Sede_SedeId",
                table: "Usuarios",
                column: "SedeId",
                principalTable: "Sede",
                principalColumn: "SedeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
