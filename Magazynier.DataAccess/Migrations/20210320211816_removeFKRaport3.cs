using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class removeFKRaport3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_RaportId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "RaportId",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaportId",
                table: "Items",
                type: "int",
                nullable: true);

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
    }
}
