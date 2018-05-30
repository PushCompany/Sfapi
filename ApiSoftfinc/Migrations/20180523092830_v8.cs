using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiSoftfinc.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dbcambio_Movil",
                table: "Dbcambio_Movil");

            migrationBuilder.RenameTable(
                name: "Dbcambio_Movil",
                newName: "TbCambiomovil");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbCambiomovil",
                table: "TbCambiomovil",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbCambiomovil",
                table: "TbCambiomovil");

            migrationBuilder.RenameTable(
                name: "TbCambiomovil",
                newName: "Dbcambio_Movil");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dbcambio_Movil",
                table: "Dbcambio_Movil",
                column: "Id");
        }
    }
}
