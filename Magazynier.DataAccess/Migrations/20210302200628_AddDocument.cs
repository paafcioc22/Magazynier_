using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class AddDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trn_GidNumer = table.Column<int>(type: "int", nullable: false),
                    Trn_GidTyp = table.Column<int>(type: "int", nullable: false),
                    Trn_Stan = table.Column<long>(type: "bigint", nullable: false),
                    Trn_NrDokumentu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trn_DataSkan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DclMagKod = table.Column<int>(type: "int", nullable: false),
                    Fmm_NrListu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fmm_NrlistuPaczka = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_DocumentId",
                table: "Items",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Document_DocumentId",
                table: "Items",
                column: "DocumentId",
                principalTable: "Document",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Document_DocumentId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Items_DocumentId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Items");
        }
    }
}
