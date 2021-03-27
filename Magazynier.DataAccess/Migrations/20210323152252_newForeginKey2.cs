using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class newForeginKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Documents_Trn_Numer",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_MsR_Numer",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_MsR_Numer",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_Trn_Numer",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaportId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_DocumentId",
                table: "Items",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RaportId",
                table: "Items",
                column: "RaportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Items_Documents_DocumentId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_DocumentId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_RaportId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "RaportId",
                table: "Items");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MsR_Numer",
                table: "Items",
                column: "MsR_Numer");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Trn_Numer",
                table: "Items",
                column: "Trn_Numer");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Documents_Trn_Numer",
                table: "Items",
                column: "Trn_Numer",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Raport_MsR_Numer",
                table: "Items",
                column: "MsR_Numer",
                principalTable: "Raport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
