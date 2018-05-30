using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiSoftfinc.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuariosapis",
                table: "Usuariosapis");

            migrationBuilder.RenameTable(
                name: "Usuariosapis",
                newName: "DBUsuariosapi");

            migrationBuilder.RenameColumn(
                name: "usuario",
                table: "DBUsuariosapi",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "clave",
                table: "DBUsuariosapi",
                newName: "Clave");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "DBUsuariosapi",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "DBUsuariosapi",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Idusuario",
                table: "DBUsuariosapi",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DBUsuariosapi",
                table: "DBUsuariosapi",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TbConfiEmp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Direccion = table.Column<string>(maxLength: 100, nullable: true),
                    Idempresa = table.Column<string>(maxLength: 100, nullable: true),
                    Ncorto = table.Column<string>(maxLength: 100, nullable: true),
                    Nlargo = table.Column<string>(maxLength: 100, nullable: true),
                    Slogan = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBConfiguracion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbConfiEmp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DBUsuariosapi",
                table: "DBUsuariosapi");

            migrationBuilder.RenameTable(
                name: "DBUsuariosapi",
                newName: "Usuariosapis");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Usuariosapis",
                newName: "usuario");

            migrationBuilder.RenameColumn(
                name: "Clave",
                table: "Usuariosapis",
                newName: "clave");

            migrationBuilder.AlterColumn<string>(
                name: "usuario",
                table: "Usuariosapis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Idusuario",
                table: "Usuariosapis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "clave",
                table: "Usuariosapis",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuariosapis",
                table: "Usuariosapis",
                column: "Id");
        }
    }
}
