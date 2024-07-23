using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatalagerEF.Context.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expediter",
                columns: table => new
                {
                    Anställningsnummer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(nullable: true),
                    Lösenord = table.Column<string>(nullable: true),
                    Roll = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expediter", x => x.Anställningsnummer);
                });

            migrationBuilder.CreateTable(
                name: "Fakturor",
                columns: table => new
                {
                    Fakturanummer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Totalpris = table.Column<int>(nullable: false),
                    Bokningsnummer = table.Column<int>(nullable: false),
                    FaktisktÅterlämningsdatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakturor", x => x.Fakturanummer);
                });

            migrationBuilder.CreateTable(
                name: "Medlemmar",
                columns: table => new
                {
                    MedlemsNummer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(nullable: true),
                    Telefonnummer = table.Column<int>(nullable: false),
                    Epostadress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medlemmar", x => x.MedlemsNummer);
                });

            migrationBuilder.CreateTable(
                name: "Bokningar",
                columns: table => new
                {
                    Bokningsnummer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aktiv = table.Column<bool>(nullable: false),
                    MedlemsNummer = table.Column<int>(nullable: true),
                    Utlämningsdatum = table.Column<DateTime>(nullable: false),
                    Återlämningsdatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bokningar", x => x.Bokningsnummer);
                    table.ForeignKey(
                        name: "FK_Bokningar_Medlemmar_MedlemsNummer",
                        column: x => x.MedlemsNummer,
                        principalTable: "Medlemmar",
                        principalColumn: "MedlemsNummer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Böcker",
                columns: table => new
                {
                    BokId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISPN = table.Column<int>(nullable: false),
                    Boktitel = table.Column<string>(nullable: true),
                    Tillgänglig = table.Column<bool>(nullable: false),
                    Bokningsnummer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Böcker", x => x.BokId);
                    table.ForeignKey(
                        name: "FK_Böcker_Bokningar_Bokningsnummer",
                        column: x => x.Bokningsnummer,
                        principalTable: "Bokningar",
                        principalColumn: "Bokningsnummer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BokBokning",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BokId = table.Column<int>(nullable: false),
                    BokningId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BokBokning", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BokBokning_Böcker_BokId",
                        column: x => x.BokId,
                        principalTable: "Böcker",
                        principalColumn: "BokId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BokBokning_Bokningar_BokningId",
                        column: x => x.BokningId,
                        principalTable: "Bokningar",
                        principalColumn: "Bokningsnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BokBokning_BokId",
                table: "BokBokning",
                column: "BokId");

            migrationBuilder.CreateIndex(
                name: "IX_BokBokning_BokningId",
                table: "BokBokning",
                column: "BokningId");

            migrationBuilder.CreateIndex(
                name: "IX_Bokningar_MedlemsNummer",
                table: "Bokningar",
                column: "MedlemsNummer");

            migrationBuilder.CreateIndex(
                name: "IX_Böcker_Bokningsnummer",
                table: "Böcker",
                column: "Bokningsnummer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BokBokning");

            migrationBuilder.DropTable(
                name: "Expediter");

            migrationBuilder.DropTable(
                name: "Fakturor");

            migrationBuilder.DropTable(
                name: "Böcker");

            migrationBuilder.DropTable(
                name: "Bokningar");

            migrationBuilder.DropTable(
                name: "Medlemmar");
        }
    }
}
