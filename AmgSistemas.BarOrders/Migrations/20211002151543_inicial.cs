using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmgSistemas.BarOrders.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGBO_TEMPRESA",
                columns: table => new
                {
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_EMPRESA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_EMPRESA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOL_IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BOL_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TEMPRESA", x => x.ID_EMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TPARAMETROS",
                columns: table => new
                {
                    ID_PARAMETRO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_PARAMETRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_PARAMETRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COD_TIPO_PARAMETRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOL_ACTIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TPARAMETROS", x => x.ID_PARAMETRO);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TTIPO_FUNCIONARIO",
                columns: table => new
                {
                    ID_TIPO_FUNCIONARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_TIPO_FUNCIONARIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_TIPO_FUNCIONARIO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TTIPO_FUNCIONARIO", x => x.ID_TIPO_FUNCIONARIO);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TFILIAL",
                columns: table => new
                {
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_FILIAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_FILIAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOL_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOL_TRABALHA_POR_MESA = table.Column<bool>(type: "bit", nullable: false),
                    BOL_SOLICITAR_TELEFONE = table.Column<bool>(type: "bit", nullable: false),
                    COD_PREFIXO_COMANDA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TFILIAL", x => x.ID_FILIAL);
                    table.ForeignKey(
                        name: "FK_AGBO_TFILIAL_AGBO_TEMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "AGBO_TEMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TGRUPO_PRODUTO",
                columns: table => new
                {
                    ID_GRUPO_PRODUTO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_GRUPO_PRODUTO_PAI = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_GRUPO_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_GRUPO_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TGRUPO_PRODUTO", x => x.ID_GRUPO_PRODUTO);
                    table.ForeignKey(
                        name: "FK_AGBO_TGRUPO_PRODUTO_AGBO_TEMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "AGBO_TEMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AGBO_TGRUPO_PRODUTO_AGBO_TGRUPO_PRODUTO_ID_GRUPO_PRODUTO_PAI",
                        column: x => x.ID_GRUPO_PRODUTO_PAI,
                        principalTable: "AGBO_TGRUPO_PRODUTO",
                        principalColumn: "ID_GRUPO_PRODUTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TFUNCIONARIO",
                columns: table => new
                {
                    ID_FUNCIONARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_TIPO_FUNCIONARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_FUNCIONARIO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOL_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TFUNCIONARIO", x => x.ID_FUNCIONARIO);
                    table.ForeignKey(
                        name: "FK_AGBO_TFUNCIONARIO_AGBO_TTIPO_FUNCIONARIO_ID_TIPO_FUNCIONARIO",
                        column: x => x.ID_TIPO_FUNCIONARIO,
                        principalTable: "AGBO_TTIPO_FUNCIONARIO",
                        principalColumn: "ID_TIPO_FUNCIONARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TMESA",
                columns: table => new
                {
                    ID_MESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_MESA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOL_ATIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TMESA", x => x.ID_MESA);
                    table.ForeignKey(
                        name: "FK_AGBO_TMESA_AGBO_TFILIAL_ID_FILIAL",
                        column: x => x.ID_FILIAL,
                        principalTable: "AGBO_TFILIAL",
                        principalColumn: "ID_FILIAL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TPARAMETRO_VALOR",
                columns: table => new
                {
                    ID_PARAMETRO_VALOR = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_PARAMETRO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DES_VALOR_PARAMETRO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TPARAMETRO_VALOR", x => x.ID_PARAMETRO_VALOR);
                    table.ForeignKey(
                        name: "FK_AGBO_TPARAMETRO_VALOR_AGBO_TEMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "AGBO_TEMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TPARAMETRO_VALOR_AGBO_TFILIAL_ID_FILIAL",
                        column: x => x.ID_FILIAL,
                        principalTable: "AGBO_TFILIAL",
                        principalColumn: "ID_FILIAL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGBO_TPARAMETRO_VALOR_AGBO_TPARAMETROS_ID_PARAMETRO",
                        column: x => x.ID_PARAMETRO,
                        principalTable: "AGBO_TPARAMETROS",
                        principalColumn: "ID_PARAMETRO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TPRODUTO",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_EMPRESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_GRUPO_PRODUTO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DES_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OBS_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOL_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    DTH_PRODUTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOL_IMAGEM = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TPRODUTO", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_AGBO_TPRODUTO_AGBO_TEMPRESA_ID_EMPRESA",
                        column: x => x.ID_EMPRESA,
                        principalTable: "AGBO_TEMPRESA",
                        principalColumn: "ID_EMPRESA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TPRODUTO_AGBO_TGRUPO_PRODUTO_ID_GRUPO_PRODUTO",
                        column: x => x.ID_GRUPO_PRODUTO,
                        principalTable: "AGBO_TGRUPO_PRODUTO",
                        principalColumn: "ID_GRUPO_PRODUTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TFILIAL_FUNCIONARIO",
                columns: table => new
                {
                    ID_FILIAL_FUNCIONARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_FUNCIONARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TFILIAL_FUNCIONARIO", x => x.ID_FILIAL_FUNCIONARIO);
                    table.ForeignKey(
                        name: "FK_AGBO_TFILIAL_FUNCIONARIO_AGBO_TFILIAL_ID_FILIAL",
                        column: x => x.ID_FILIAL,
                        principalTable: "AGBO_TFILIAL",
                        principalColumn: "ID_FILIAL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TFILIAL_FUNCIONARIO_AGBO_TFUNCIONARIO_ID_FUNCIONARIO",
                        column: x => x.ID_FUNCIONARIO,
                        principalTable: "AGBO_TFUNCIONARIO",
                        principalColumn: "ID_FUNCIONARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TMESA_ATENDENTE",
                columns: table => new
                {
                    ID_MESA_ATENDENTE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MESA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_FUNCIONARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOL_CORRENTE = table.Column<bool>(type: "bit", nullable: false),
                    DES_TELEFONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_COMANDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_CHAVE_ACESSO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TMESA_ATENDENTE", x => x.ID_MESA_ATENDENTE);
                    table.ForeignKey(
                        name: "FK_AGBO_TMESA_ATENDENTE_AGBO_TFILIAL_ID_FILIAL",
                        column: x => x.ID_FILIAL,
                        principalTable: "AGBO_TFILIAL",
                        principalColumn: "ID_FILIAL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TMESA_ATENDENTE_AGBO_TFUNCIONARIO_ID_FUNCIONARIO",
                        column: x => x.ID_FUNCIONARIO,
                        principalTable: "AGBO_TFUNCIONARIO",
                        principalColumn: "ID_FUNCIONARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TMESA_ATENDENTE_AGBO_TMESA_ID_MESA",
                        column: x => x.ID_MESA,
                        principalTable: "AGBO_TMESA",
                        principalColumn: "ID_MESA",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TPRODUTO_FILIAL",
                columns: table => new
                {
                    ID_PRODUTO_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUM_VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NUM_QUANTIDADE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AGBO_TPRODUTOID_PRODUTO = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TPRODUTO_FILIAL", x => x.ID_PRODUTO_FILIAL);
                    table.ForeignKey(
                        name: "FK_AGBO_TPRODUTO_FILIAL_AGBO_TFILIAL_ID_FILIAL",
                        column: x => x.ID_FILIAL,
                        principalTable: "AGBO_TFILIAL",
                        principalColumn: "ID_FILIAL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TPRODUTO_FILIAL_AGBO_TPRODUTO_AGBO_TPRODUTOID_PRODUTO",
                        column: x => x.AGBO_TPRODUTOID_PRODUTO,
                        principalTable: "AGBO_TPRODUTO",
                        principalColumn: "ID_PRODUTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TCOMANDA",
                columns: table => new
                {
                    ID_COMANDA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MESA = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ID_MESA_ATENDENTE = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    COD_COMANDA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TCOMANDA", x => x.ID_COMANDA);
                    table.ForeignKey(
                        name: "FK_AGBO_TCOMANDA_AGBO_TFILIAL_ID_FILIAL",
                        column: x => x.ID_FILIAL,
                        principalTable: "AGBO_TFILIAL",
                        principalColumn: "ID_FILIAL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGBO_TCOMANDA_AGBO_TMESA_ATENDENTE_ID_MESA_ATENDENTE",
                        column: x => x.ID_MESA_ATENDENTE,
                        principalTable: "AGBO_TMESA_ATENDENTE",
                        principalColumn: "ID_MESA_ATENDENTE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGBO_TCOMANDA_AGBO_TMESA_ID_MESA",
                        column: x => x.ID_MESA,
                        principalTable: "AGBO_TMESA",
                        principalColumn: "ID_MESA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TDISPOSITIVO",
                columns: table => new
                {
                    ID_DISPOSITIVO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MESA_ATENDENTE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_DISPOSITIVO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DTH_DISPOSITIVO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TDISPOSITIVO", x => x.ID_DISPOSITIVO);
                    table.ForeignKey(
                        name: "FK_AGBO_TDISPOSITIVO_AGBO_TMESA_ATENDENTE_ID_MESA_ATENDENTE",
                        column: x => x.ID_MESA_ATENDENTE,
                        principalTable: "AGBO_TMESA_ATENDENTE",
                        principalColumn: "ID_MESA_ATENDENTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AGBO_TITEM_COMANDA",
                columns: table => new
                {
                    ID_ITEM_COMANDA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_COMANDA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_PRODUTO_FILIAL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUM_QUANTIDADE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DTH_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGBO_TITEM_COMANDA", x => x.ID_ITEM_COMANDA);
                    table.ForeignKey(
                        name: "FK_AGBO_TITEM_COMANDA_AGBO_TCOMANDA_ID_COMANDA",
                        column: x => x.ID_COMANDA,
                        principalTable: "AGBO_TCOMANDA",
                        principalColumn: "ID_COMANDA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AGBO_TITEM_COMANDA_AGBO_TPRODUTO_FILIAL_ID_PRODUTO_FILIAL",
                        column: x => x.ID_PRODUTO_FILIAL,
                        principalTable: "AGBO_TPRODUTO_FILIAL",
                        principalColumn: "ID_PRODUTO_FILIAL",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TCOMANDA_ID_FILIAL",
                table: "AGBO_TCOMANDA",
                column: "ID_FILIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TCOMANDA_ID_MESA",
                table: "AGBO_TCOMANDA",
                column: "ID_MESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TCOMANDA_ID_MESA_ATENDENTE",
                table: "AGBO_TCOMANDA",
                column: "ID_MESA_ATENDENTE");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TDISPOSITIVO_ID_MESA_ATENDENTE",
                table: "AGBO_TDISPOSITIVO",
                column: "ID_MESA_ATENDENTE");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TFILIAL_ID_EMPRESA",
                table: "AGBO_TFILIAL",
                column: "ID_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TFILIAL_FUNCIONARIO_ID_FILIAL",
                table: "AGBO_TFILIAL_FUNCIONARIO",
                column: "ID_FILIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TFILIAL_FUNCIONARIO_ID_FUNCIONARIO",
                table: "AGBO_TFILIAL_FUNCIONARIO",
                column: "ID_FUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TFUNCIONARIO_ID_TIPO_FUNCIONARIO",
                table: "AGBO_TFUNCIONARIO",
                column: "ID_TIPO_FUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TGRUPO_PRODUTO_ID_EMPRESA",
                table: "AGBO_TGRUPO_PRODUTO",
                column: "ID_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TGRUPO_PRODUTO_ID_GRUPO_PRODUTO_PAI",
                table: "AGBO_TGRUPO_PRODUTO",
                column: "ID_GRUPO_PRODUTO_PAI");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TITEM_COMANDA_ID_COMANDA",
                table: "AGBO_TITEM_COMANDA",
                column: "ID_COMANDA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TITEM_COMANDA_ID_PRODUTO_FILIAL",
                table: "AGBO_TITEM_COMANDA",
                column: "ID_PRODUTO_FILIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TMESA_ID_FILIAL",
                table: "AGBO_TMESA",
                column: "ID_FILIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TMESA_ATENDENTE_ID_FILIAL",
                table: "AGBO_TMESA_ATENDENTE",
                column: "ID_FILIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TMESA_ATENDENTE_ID_FUNCIONARIO",
                table: "AGBO_TMESA_ATENDENTE",
                column: "ID_FUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TMESA_ATENDENTE_ID_MESA",
                table: "AGBO_TMESA_ATENDENTE",
                column: "ID_MESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPARAMETRO_VALOR_ID_EMPRESA",
                table: "AGBO_TPARAMETRO_VALOR",
                column: "ID_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPARAMETRO_VALOR_ID_FILIAL",
                table: "AGBO_TPARAMETRO_VALOR",
                column: "ID_FILIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPARAMETRO_VALOR_ID_PARAMETRO",
                table: "AGBO_TPARAMETRO_VALOR",
                column: "ID_PARAMETRO");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPRODUTO_ID_EMPRESA",
                table: "AGBO_TPRODUTO",
                column: "ID_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPRODUTO_ID_GRUPO_PRODUTO",
                table: "AGBO_TPRODUTO",
                column: "ID_GRUPO_PRODUTO");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPRODUTO_FILIAL_AGBO_TPRODUTOID_PRODUTO",
                table: "AGBO_TPRODUTO_FILIAL",
                column: "AGBO_TPRODUTOID_PRODUTO");

            migrationBuilder.CreateIndex(
                name: "IX_AGBO_TPRODUTO_FILIAL_ID_FILIAL",
                table: "AGBO_TPRODUTO_FILIAL",
                column: "ID_FILIAL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGBO_TDISPOSITIVO");

            migrationBuilder.DropTable(
                name: "AGBO_TFILIAL_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "AGBO_TITEM_COMANDA");

            migrationBuilder.DropTable(
                name: "AGBO_TPARAMETRO_VALOR");

            migrationBuilder.DropTable(
                name: "AGBO_TCOMANDA");

            migrationBuilder.DropTable(
                name: "AGBO_TPRODUTO_FILIAL");

            migrationBuilder.DropTable(
                name: "AGBO_TPARAMETROS");

            migrationBuilder.DropTable(
                name: "AGBO_TMESA_ATENDENTE");

            migrationBuilder.DropTable(
                name: "AGBO_TPRODUTO");

            migrationBuilder.DropTable(
                name: "AGBO_TFUNCIONARIO");

            migrationBuilder.DropTable(
                name: "AGBO_TMESA");

            migrationBuilder.DropTable(
                name: "AGBO_TGRUPO_PRODUTO");

            migrationBuilder.DropTable(
                name: "AGBO_TTIPO_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "AGBO_TFILIAL");

            migrationBuilder.DropTable(
                name: "AGBO_TEMPRESA");
        }
    }
}
