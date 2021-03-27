using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class newForeginKey5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "DocumentTrn_GidNumer",
                table: "Items",
                newName: "Trn_GidNumer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");

      
            migrationBuilder.AddForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "Trn_GidNumer",
                table: "Items",
                newName: "DocumentTrn_GidNumer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Trn_GidNumer");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Trn_GidNumer",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
