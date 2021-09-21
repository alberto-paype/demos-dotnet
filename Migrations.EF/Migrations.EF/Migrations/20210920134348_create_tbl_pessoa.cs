using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations.EF.Migrations
{
    public partial class create_tbl_pessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FS_PESSOA",
                columns: table => new
                {
                    handle = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    razao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apelido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FS_PESSOA", x => x.handle);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FS_PESSOA");
        }
    }
}
