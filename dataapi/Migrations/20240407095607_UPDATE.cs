using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dataapi.Migrations
{
    public partial class UPDATE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_DISPENSELOG",
                columns: table => new
                {
                    DISPENSELOGID = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DISPENSELOG", x => x.DISPENSELOGID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_DISPENSELOG");
        }
    }
}
