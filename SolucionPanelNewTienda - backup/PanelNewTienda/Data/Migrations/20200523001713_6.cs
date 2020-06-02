using Microsoft.EntityFrameworkCore.Migrations;

namespace PanelNewTienda.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publicado",
                table: "Productos",
                newName: "Publicado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publicado",
                table: "Productos",
                newName: "publicado");
        }
    }
}
