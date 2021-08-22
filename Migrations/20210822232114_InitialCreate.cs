using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestringApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Restrings",
                columns: table => new
                {
                    RestringId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RacketBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RacketModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensionCrosses = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    TensionMains = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    DateStrung = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    PaymentNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restrings", x => x.RestringId);
                    table.ForeignKey(
                        name: "FK_Restrings_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restrings_ContactId",
                table: "Restrings",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restrings");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
