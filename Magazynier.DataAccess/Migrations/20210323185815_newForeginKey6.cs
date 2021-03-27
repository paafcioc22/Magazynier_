using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class newForeginKey6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Trn_GidNumer",
                table: "Items",
                newName: "RaportId");

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_RaportId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "RaportId",
                table: "Items",
                newName: "Trn_GidNumer");
        }
    }
}
