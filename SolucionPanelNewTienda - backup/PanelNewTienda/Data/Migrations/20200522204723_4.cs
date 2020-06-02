using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PanelNewTienda.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen1",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen1",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "ProductoIdProducto",
                table: "Imagenes",
                type: "int",
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
    }
}
