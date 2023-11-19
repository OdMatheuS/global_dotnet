using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Global.Migrations
{
    /// <inheritdoc />
    public partial class BancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtualizacaoSaudePubs",
                columns: table => new
                {
                    AtualizacaoSaudePubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInfoSaude = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtualizacaoSaudePubs", x => x.AtualizacaoSaudePubId);
                });

            migrationBuilder.CreateTable(
                name: "TB_DADOS_SUPLE_USR",
                columns: table => new
                {
                    DadosSuplementaresUsrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DADOS_SUPLE_USR", x => x.DadosSuplementaresUsrId);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TempoSono = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PraticaEsporte = table.Column<bool>(type: "bit", nullable: false),
                    HabitosSaude = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Usuario_Atualizacao_Saude_Pub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Usuario_Atualizacao_Saude_Pub", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtualizacaoSaudePubs");

            migrationBuilder.DropTable(
                name: "TB_DADOS_SUPLE_USR");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_Usuario_Atualizacao_Saude_Pub");
        }
    }
}
