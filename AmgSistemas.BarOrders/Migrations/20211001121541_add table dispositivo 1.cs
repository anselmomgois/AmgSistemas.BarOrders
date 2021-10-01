using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmgSistemas.BarOrders.Migrations
{
    public partial class addtabledispositivo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGBO_TDISPOSITIVO",
                columns: table => new
                {
                    ID_DISPOSITIVO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MESA_ATENDENTE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_DISPOSITIVO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DTH_DISPOSITIVO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TDISPOSITIVO", x => x.ID_DISPOSITIVO);
                    table.ForeignKey(
                        name: "FK_AGBO_TDISPOSITIVO_AGBO_TMESA_ATENDENTE_ID_MESA_ATENDENTE",
                        column: x => x.ID_MESA_ATENDENTE,
                        principalTable: "AGBO_TMESA_ATENDENTE",
                        principalColumn: "ID_MESA_ATENDENTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TDISPOSITIVO_ID_MESA_ATENDENTE",
                table: "AGBO_TDISPOSITIVO",
                column: "ID_MESA_ATENDENTE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGBO_TDISPOSITIVO");
        }
    }
}
