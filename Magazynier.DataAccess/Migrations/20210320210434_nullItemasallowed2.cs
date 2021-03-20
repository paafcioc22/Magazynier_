using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class nullItemasallowed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "RaportId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "RaportId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Documents_DocumentId",
                table: "Items",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Raport_RaportId",
                table: "Items",
                column: "RaportId",
                principalTable: "Raport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
