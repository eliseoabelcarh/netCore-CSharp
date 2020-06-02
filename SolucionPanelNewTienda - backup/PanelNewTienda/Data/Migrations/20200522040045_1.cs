using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PanelNewTienda.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdTienda",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiendaIdTienda",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    IdImagen = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloImagen = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    IdProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.IdImagen);
                });

            migrationBuilder.CreateTable(
                name: "RedesSociales",
                columns: table => new
                {
                    IdRedSocial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Whatsapp = table.Column<string>(maxLength: 150, nullable: true),
                    Facebook = table.Column<string>(maxLength: 150, nullable: true),
                    Instagram = table.Column<string>(maxLength: 150, nullable: true),
                    Twitter = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSociales", x => x.IdRedSocial);
                });

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    IdTienda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTienda = table.Column<string>(maxLength: 100, nullable: false),
                    Publicada = table.Column<bool>(nullable: false),
                    IdRedSocial = table.Column<int>(nullable: false),
                    RedSocialIdRedSocial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.IdTienda);
                    table.ForeignKey(
                        name: "FK_Tiendas_RedesSociales_RedSocialIdRedSocial",
                        column: x => x.RedSocialIdRedSocial,
                        principalTable: "RedesSociales",
                        principalColumn: "IdRedSocial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(maxLength: 150, nullable: false),
                    DescripcionProducto = table.Column<string>(maxLength: 2000, nullable: false),
                    PrecioProducto = table.Column<double>(nullable: false),
                    IdTienda = table.Column<int>(nullable: false),
                    TiendaIdTienda = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Tiendas_TiendaIdTienda",
                        column: x => x.TiendaIdTienda,
                        principalTable: "Tiendas",
                        principalColumn: "IdTienda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TiendaIdTienda",
                table: "AspNetUsers",
                column: "TiendaIdTienda");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TiendaIdTienda",
                table: "Productos",
                column: "TiendaIdTienda");

            migrationBuilder.CreateIndex(
                name: "IX_Tiendas_RedSocialIdRedSocial",
                table: "Tiendas",
                column: "RedSocialIdRedSocial");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tiendas_TiendaIdTienda",
                table: "AspNetUsers",
                column: "TiendaIdTienda",
                principalTable: "Tiendas",
                principalColumn: "IdTienda",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tiendas_TiendaIdTienda",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Tiendas");

            migrationBuilder.DropTable(
                name: "RedesSociales");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TiendaIdTienda",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdTienda",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TiendaIdTienda",
                table: "AspNetUsers");
        }
    }
}
