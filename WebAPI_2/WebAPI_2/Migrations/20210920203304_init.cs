using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pessoas",
                columns: table => new
                {
                    id_pessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_completo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    altura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoas", x => x.id_pessoa);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pessoas");
        }
    }
}
