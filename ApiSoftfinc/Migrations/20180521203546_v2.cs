using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiSoftfinc.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dbmoviles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<string>(maxLength: 50, nullable: true),
                    F_registro = table.Column<DateTime>(nullable: false),
                    Idempresa = table.Column<string>(maxLength: 50, nullable: true),
                    Idusuario = table.Column<string>(maxLength: 50, nullable: true),
                    Imei = table.Column<string>(maxLength: 20, nullable: true),
                    Nota = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Uidapp = table.Column<string>(maxLength: 50, nullable: true),
                    Ultip = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dbmoviles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dbmoviles");
        }
    }
}
