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
                name: "SugestoesSaude",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sugestao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataSugestao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugestoesSaude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtualizacaoSaudePubs",
                columns: table => new
                {
                    AtualizacaoSaudePubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInfoSaude = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtualizacaoSaudePubs", x => x.AtualizacaoSaudePubId);
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
                    HabitosSaude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtSaudePubId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_USUARIO_AtualizacaoSaudePubs_AtSaudePubId",
                        column: x => x.AtSaudePubId,
                        principalTable: "AtualizacaoSaudePubs",
                        principalColumn: "AtualizacaoSaudePubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DuvidasUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pergunta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuvidasUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuvidasUsuario_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfosSaudeUsr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HabitosSaude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alimentacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasSono = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfosSaudeUsr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfosSaudeUsr_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_DADOS_SUPLE_USR",
                columns: table => new
                {
                    DadosSuplementaresUsrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DADOS_SUPLE_USR", x => x.DadosSuplementaresUsrId);
                    table.ForeignKey(
                        name: "FK_TB_DADOS_SUPLE_USR_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Usuario_Atualizacao_Saude_Pub",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    AtSaudePubId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    AtualizacaoSaudePubId = table.Column<int>(type: "int", nullable: true),
                    UsuarioId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Usuario_Atualizacao_Saude_Pub", x => new { x.AtSaudePubId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_TB_Usuario_Atualizacao_Saude_Pub_AtualizacaoSaudePubs_AtSaudePubId",
                        column: x => x.AtSaudePubId,
                        principalTable: "AtualizacaoSaudePubs",
                        principalColumn: "AtualizacaoSaudePubId");
                    table.ForeignKey(
                        name: "FK_TB_Usuario_Atualizacao_Saude_Pub_AtualizacaoSaudePubs_AtualizacaoSaudePubId",
                        column: x => x.AtualizacaoSaudePubId,
                        principalTable: "AtualizacaoSaudePubs",
                        principalColumn: "AtualizacaoSaudePubId");
                    table.ForeignKey(
                        name: "FK_TB_Usuario_Atualizacao_Saude_Pub_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TB_Usuario_Atualizacao_Saude_Pub_TB_USUARIO_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "TB_USUARIO",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtualizacaoSaudePubs_UsuarioId",
                table: "AtualizacaoSaudePubs",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DuvidasUsuario_UsuarioId",
                table: "DuvidasUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InfosSaudeUsr_UsuarioId",
                table: "InfosSaudeUsr",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_DADOS_SUPLE_USR_UsuarioId",
                table: "TB_DADOS_SUPLE_USR",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_AtSaudePubId",
                table: "TB_USUARIO",
                column: "AtSaudePubId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Usuario_Atualizacao_Saude_Pub_AtualizacaoSaudePubId",
                table: "TB_Usuario_Atualizacao_Saude_Pub",
                column: "AtualizacaoSaudePubId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Usuario_Atualizacao_Saude_Pub_UsuarioId",
                table: "TB_Usuario_Atualizacao_Saude_Pub",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Usuario_Atualizacao_Saude_Pub_UsuarioId1",
                table: "TB_Usuario_Atualizacao_Saude_Pub",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AtualizacaoSaudePubs_TB_USUARIO_UsuarioId",
                table: "AtualizacaoSaudePubs",
                column: "UsuarioId",
                principalTable: "TB_USUARIO",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtualizacaoSaudePubs_TB_USUARIO_UsuarioId",
                table: "AtualizacaoSaudePubs");

            migrationBuilder.DropTable(
                name: "DuvidasUsuario");

            migrationBuilder.DropTable(
                name: "InfosSaudeUsr");

            migrationBuilder.DropTable(
                name: "SugestoesSaude");

            migrationBuilder.DropTable(
                name: "TB_DADOS_SUPLE_USR");

            migrationBuilder.DropTable(
                name: "TB_Usuario_Atualizacao_Saude_Pub");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "AtualizacaoSaudePubs");
        }
    }
}
