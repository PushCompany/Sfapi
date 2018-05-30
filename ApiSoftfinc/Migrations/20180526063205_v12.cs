using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiSoftfinc.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_empActualizarapp",
                table: "empActualizarapp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dbmoviles",
                table: "Dbmoviles");

            migrationBuilder.RenameTable(
                name: "empActualizarapp",
                newName: "TbActualizarAppEmpr");

            migrationBuilder.RenameTable(
                name: "Dbmoviles",
                newName: "TbMoviles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbActualizarAppEmpr",
                table: "TbActualizarAppEmpr",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbMoviles",
                table: "TbMoviles",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TbMoviles",
                table: "TbMoviles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbActualizarAppEmpr",
                table: "TbActualizarAppEmpr");

            migrationBuilder.RenameTable(
                name: "TbMoviles",
                newName: "Dbmoviles");

            migrationBuilder.RenameTable(
                name: "TbActualizarAppEmpr",
                newName: "empActualizarapp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dbmoviles",
                table: "Dbmoviles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empActualizarapp",
                table: "empActualizarapp",
                column: "Id");
        }
    }
}
