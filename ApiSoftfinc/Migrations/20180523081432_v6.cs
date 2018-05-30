using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiSoftfinc.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBUsuariosapi");

            migrationBuilder.CreateTable(
                name: "Dbcambio_Movil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ejecutado = table.Column<int>(nullable: false),
                    Fechaejecutado = table.Column<DateTime>(type: "datetime", nullable: true),
                    Fechas = table.Column<DateTime>(type: "datetime", nullable: true),
                    Idregistro = table.Column<string>(maxLength: 50, nullable: true),
                    Imei = table.Column<string>(maxLength: 20, nullable: true),
                    Nota = table.Column<string>(maxLength: 50, nullable: true),
                    Notaejecucion = table.Column<string>(maxLength: 50, nullable: true),
                    Ubicacion = table.Column<string>(maxLength: 300, nullable: true),
                    Uidapp = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dbcambio_Movil", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dbcambio_Movil");

            migrationBuilder.CreateTable(
                name: "DBUsuariosapi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<string>(maxLength: 100, nullable: true),
                    Idusuario = table.Column<string>(maxLength: 100, nullable: true),
                    Usuario = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBUsuariosapi", x => x.Id);
                });
        }
    }
}
