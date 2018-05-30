using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiSoftfinc.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "version",
                table: "Dbmoviles",
                newName: "Version");

            migrationBuilder.AddColumn<bool>(
                name: "Cambios",
                table: "Dbmoviles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cambios",
                table: "Dbmoviles");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Dbmoviles",
                newName: "version");
        }
    }
}
