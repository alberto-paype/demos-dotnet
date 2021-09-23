using Microsoft.EntityFrameworkCore.Migrations;

namespace web_api_3_balta.io.Migrations
{
    public partial class update_table_pessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Identificacao",
                table: "FS_PESSOA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoriaRNTRC",
                table: "FS_PESSOA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RNTRC",
                table: "FS_PESSOA",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaRNTRC",
                table: "FS_PESSOA");

            migrationBuilder.DropColumn(
                name: "RNTRC",
                table: "FS_PESSOA");

            migrationBuilder.AlterColumn<string>(
                name: "Identificacao",
                table: "FS_PESSOA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
