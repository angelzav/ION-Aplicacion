using Microsoft.EntityFrameworkCore.Migrations;

namespace ION_Aplicacion.Migrations
{
    public partial class NombreCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Cliente");
        }
    }
}
