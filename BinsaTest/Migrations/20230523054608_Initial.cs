using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BinsaTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Domicilio = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    CodigoPostal = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    Poblacion = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
