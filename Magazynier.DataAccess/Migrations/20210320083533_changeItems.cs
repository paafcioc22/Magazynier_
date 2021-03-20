using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class changeItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaportId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Raport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MsR_MagNumer = table.Column<int>(type: "int", nullable: false),
                    MsR_TrnNumer = table.Column<int>(type: "int", nullable: false),
                    MsR_TwrNumer = table.Column<int>(type: "int", nullable: false),
                    MsR_Ilosc = table.Column<int>(type: "int", nullable: false),
                    MsR_TypDok = table.Column<int>(type: "int", nullable: false),
                    MsR_StanDok = table.Column<byte>(type: "tinyint", nullable: false),
                    MsR_Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MsR_NewGidNumer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raport", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_RaportId",
                table: "Items",
                column: "RaportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items",
                column: "RaportId",
                principalTable: "Raport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Raport");

            migrationBuilder.DropIndex(
                name: "IX_Items_RaportId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "RaportId",
                table: "Items");
        }
    }
}
