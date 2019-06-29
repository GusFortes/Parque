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
                name: "Desconto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeDesconto = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desconto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Passaportes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(nullable: true),
                    NroDias = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    DataInicial = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passaportes", x => x.ID);
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
                        name: "FK_Entrada_Passaportes_PassaporteID",
                        column: x => x.PassaporteID,
                        principalTable: "Passaportes",
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
                name: "Desconto");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Passaportes");
        }
    }
}
