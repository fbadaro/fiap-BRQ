using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.BRQ.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BRQ01_CANDIDATO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPF_Numero = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CPF_Emissor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CPF_UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Email_Endereco = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_Complemento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Endereco_Bairro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_CEP = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    RG_Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRQ01_CANDIDATO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BRQ03_CERTIFICADO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OrganizacaoEmissora = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Expiracao = table.Column<bool>(type: "bit", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataExpiracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoCredencial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrlCredencial = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRQ03_CERTIFICADO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BRQ02_ESPECIALIDADE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRQ02_ESPECIALIDADE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BRQ02_ESPECIALIDADE_BRQ01_CANDIDATO_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "BRQ01_CANDIDATO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BRQ02_ESPECIALIDADE_BRQ03_CERTIFICADO_CertificadoId",
                        column: x => x.CertificadoId,
                        principalTable: "BRQ03_CERTIFICADO",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BRQ02_ESPECIALIDADE_CandidatoId",
                table: "BRQ02_ESPECIALIDADE",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_BRQ02_ESPECIALIDADE_CertificadoId",
                table: "BRQ02_ESPECIALIDADE",
                column: "CertificadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BRQ02_ESPECIALIDADE");

            migrationBuilder.DropTable(
                name: "BRQ01_CANDIDATO");

            migrationBuilder.DropTable(
                name: "BRQ03_CERTIFICADO");
        }
    }
}
