using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParqueBLL.Migrations
{
    public partial class Parque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passaporte",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(nullable: true),
                    NroDias = table.Column<int>(nullable: false),
                    DataInicial = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passaporte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    PassaporteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entrada_Passaporte_PassaporteID",
                        column: x => x.PassaporteID,
                        principalTable: "Passaporte",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_PassaporteID",
                table: "Entrada",
                column: "PassaporteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Passaporte");
        }
    }
}
