using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreBGH.Migrations
{
    public partial class hanes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aufgaben",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    Getan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aufgaben", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aufgaben");
        }
    }
}
