using Microsoft.EntityFrameworkCore.Migrations;

namespace PanelNewTienda.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoIdProducto",
                table: "Imagenes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_ProductoIdProducto",
                table: "Imagenes",
                column: "ProductoIdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagenes_Productos_ProductoIdProducto",
                table: "Imagenes",
                column: "ProductoIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagenes_Productos_ProductoIdProducto",
                table: "Imagenes");

            migrationBuilder.DropIndex(
                name: "IX_Imagenes_ProductoIdProducto",
                table: "Imagenes");

            migrationBuilder.DropColumn(
                name: "ProductoIdProducto",
                table: "Imagenes");
        }
    }
}
