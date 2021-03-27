using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class newForeginKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "RaportId",
                table: "Items",
                newName: "Trn_Numer");

            migrationBuilder.RenameColumn(
                name: "DocumentId",
                table: "Items",
                newName: "MsR_Numer");

            migrationBuilder.RenameIndex(
                name: "IX_Items_RaportId",
                table: "Items",
                newName: "IX_Items_Trn_Numer");

            migrationBuilder.RenameIndex(
                name: "IX_Items_DocumentId",
                table: "Items",
                newName: "IX_Items_MsR_Numer");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Documents_Trn_Numer",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_MsR_Numer",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Trn_Numer",
                table: "Items",
                newName: "RaportId");

            migrationBuilder.RenameColumn(
                name: "MsR_Numer",
                table: "Items",
                newName: "DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_Trn_Numer",
                table: "Items",
                newName: "IX_Items_RaportId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_MsR_Numer",
                table: "Items",
                newName: "IX_Items_DocumentId");

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
    }
}
