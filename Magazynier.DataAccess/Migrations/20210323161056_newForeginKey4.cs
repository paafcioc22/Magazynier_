using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazynier.DataAccess.Migrations
{
    public partial class newForeginKey4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Trn_GidNumer",
                table: "Items",
                newName: "DocumentTrn_GidNumer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DocumentTrn_GidNumer",
                table: "Items",
                newName: "Trn_GidNumer");
        }
    }
}
