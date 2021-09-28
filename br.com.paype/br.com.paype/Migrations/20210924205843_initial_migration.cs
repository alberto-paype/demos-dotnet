using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace br.com.paype.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FS_EMPRESAREGIME",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FS_EMPRESAREGIME", x => x.Handle);
                });

            migrationBuilder.CreateTable(
                name: "FS_PESSOA",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identificacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cliente = table.Column<bool>(type: "bit", nullable: false),
                    Funcionário = table.Column<bool>(type: "bit", nullable: false),
                    Motorista = table.Column<bool>(type: "bit", nullable: false),
                    Transportador = table.Column<bool>(type: "bit", nullable: false),
                    Fornecedor = table.Column<bool>(type: "bit", nullable: false),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dependentes = table.Column<int>(type: "int", nullable: false),
                    NomePai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgaoEmissor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    INSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RNTRC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaRNTRC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FS_PESSOA", x => x.Handle);
                });

            migrationBuilder.CreateTable(
                name: "TI_PERFIL",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_PERFIL", x => x.Handle);
                });

            migrationBuilder.CreateTable(
                name: "TI_PERMISSAO",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_PERMISSAO", x => x.Handle);
                });

            migrationBuilder.CreateTable(
                name: "TI_USUARIO",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_USUARIO", x => x.Handle);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FS_EMPRESA",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoDigital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenhaCertificado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VencimentoCertificado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegimeEstadualHandle = table.Column<int>(type: "int", nullable: false),
                    RegimeFederalHandle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FS_EMPRESA", x => x.Handle);
                    table.ForeignKey(
                        name: "FK_FS_EMPRESA_FS_EMPRESAREGIME_RegimeEstadualHandle",
                        column: x => x.RegimeEstadualHandle,
                        principalTable: "FS_EMPRESAREGIME",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FS_EMPRESA_FS_EMPRESAREGIME_RegimeFederalHandle",
                        column: x => x.RegimeFederalHandle,
                        principalTable: "FS_EMPRESAREGIME",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TI_PAPEL",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissaoHandle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_PAPEL", x => x.Handle);
                    table.ForeignKey(
                        name: "FK_TI_PAPEL_TI_PERMISSAO_PermissaoHandle",
                        column: x => x.PermissaoHandle,
                        principalTable: "TI_PERMISSAO",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TI_PAPEL_USUARIO",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PapelHandle = table.Column<int>(type: "int", nullable: false),
                    UsuarioHandle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_PAPEL_USUARIO", x => x.Handle);
                    table.ForeignKey(
                        name: "FK_TI_PAPEL_USUARIO_TI_PAPEL_PapelHandle",
                        column: x => x.PapelHandle,
                        principalTable: "TI_PAPEL",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TI_PAPEL_USUARIO_TI_USUARIO_UsuarioHandle",
                        column: x => x.UsuarioHandle,
                        principalTable: "TI_USUARIO",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TI_PERFIL_PAPEL",
                columns: table => new
                {
                    Handle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilHandle = table.Column<int>(type: "int", nullable: false),
                    PapelHandle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_PERFIL_PAPEL", x => x.Handle);
                    table.ForeignKey(
                        name: "FK_TI_PERFIL_PAPEL_TI_PAPEL_PapelHandle",
                        column: x => x.PapelHandle,
                        principalTable: "TI_PAPEL",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TI_PERFIL_PAPEL_TI_PERFIL_PerfilHandle",
                        column: x => x.PerfilHandle,
                        principalTable: "TI_PERFIL",
                        principalColumn: "Handle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FS_EMPRESA_RegimeEstadualHandle",
                table: "FS_EMPRESA",
                column: "RegimeEstadualHandle");

            migrationBuilder.CreateIndex(
                name: "IX_FS_EMPRESA_RegimeFederalHandle",
                table: "FS_EMPRESA",
                column: "RegimeFederalHandle");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TI_PAPEL_PermissaoHandle",
                table: "TI_PAPEL",
                column: "PermissaoHandle");

            migrationBuilder.CreateIndex(
                name: "IX_TI_PAPEL_USUARIO_PapelHandle",
                table: "TI_PAPEL_USUARIO",
                column: "PapelHandle");

            migrationBuilder.CreateIndex(
                name: "IX_TI_PAPEL_USUARIO_UsuarioHandle",
                table: "TI_PAPEL_USUARIO",
                column: "UsuarioHandle");

            migrationBuilder.CreateIndex(
                name: "IX_TI_PERFIL_PAPEL_PapelHandle",
                table: "TI_PERFIL_PAPEL",
                column: "PapelHandle");

            migrationBuilder.CreateIndex(
                name: "IX_TI_PERFIL_PAPEL_PerfilHandle",
                table: "TI_PERFIL_PAPEL",
                column: "PerfilHandle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FS_EMPRESA");

            migrationBuilder.DropTable(
                name: "FS_PESSOA");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "TI_PAPEL_USUARIO");

            migrationBuilder.DropTable(
                name: "TI_PERFIL_PAPEL");

            migrationBuilder.DropTable(
                name: "FS_EMPRESAREGIME");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TI_USUARIO");

            migrationBuilder.DropTable(
                name: "TI_PAPEL");

            migrationBuilder.DropTable(
                name: "TI_PERFIL");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TI_PERMISSAO");
        }
    }
}
