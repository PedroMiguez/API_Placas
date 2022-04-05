using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace API_Placas.Migrations
{
    public partial class MigracaoPlaca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Placas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome_Placa = table.Column<string>(type: "text", nullable: false),
                    Nome_Operador = table.Column<string>(type: "text", nullable: false),
                    Meio = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    Quantidade_Colonias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Placas");
        }
    }
}
