using Microsoft.EntityFrameworkCore.Migrations;

namespace dataapi.Migrations
{
    public partial class MyFirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TTBL_DISPENSELOG",
                table: "TTBL_DISPENSELOG");

            migrationBuilder.RenameTable(
                name: "TTBL_DISPENSELOG",
                newName: "TBL_DISPENSELOG");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_DISPENSELOG",
                table: "TBL_DISPENSELOG",
                column: "DISPENSELOGID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_DISPENSELOG",
                table: "TBL_DISPENSELOG");

            migrationBuilder.RenameTable(
                name: "TBL_DISPENSELOG",
                newName: "TTBL_DISPENSELOG");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TTBL_DISPENSELOG",
                table: "TTBL_DISPENSELOG",
                column: "DISPENSELOGID");
        }
    }
}
