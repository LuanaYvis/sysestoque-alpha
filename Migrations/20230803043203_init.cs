using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace sysestoque_alpha.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    cnpj = table.Column<string>(type: "longtext", nullable: true),
                    endereco = table.Column<string>(type: "longtext", nullable: true),
                    email = table.Column<string>(type: "longtext", nullable: true),
                    fone = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Nome);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotaSaida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    valorTotal = table.Column<float>(type: "float", nullable: false),
                    dataSaida = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaSaida", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Login = table.Column<string>(type: "varchar(255)", nullable: false),
                    HashSenha = table.Column<string>(type: "longtext", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false),
                    Telefone = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Login);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false),
                    Estoque = table.Column<float>(type: "float", nullable: false),
                    EstoqueMax = table.Column<float>(type: "float", nullable: false),
                    EstoqueMedio = table.Column<float>(type: "float", nullable: false),
                    EstoqueMin = table.Column<float>(type: "float", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    UnidadeMedida = table.Column<int>(type: "int", nullable: false),
                    UnidadeMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_UnidadeMediaId",
                        column: x => x.UnidadeMediaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotaEntrada",
                columns: table => new
                {
                    IdNotaEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    dataEntrada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FornecedorNome = table.Column<string>(type: "varchar(255)", nullable: true),
                    ValorTotal = table.Column<float>(type: "float", nullable: false),
                    loginUsuarioResponsavel = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaEntrada", x => x.IdNotaEntrada);
                    table.ForeignKey(
                        name: "FK_NotaEntrada_Fornecedor_FornecedorNome",
                        column: x => x.FornecedorNome,
                        principalTable: "Fornecedor",
                        principalColumn: "Nome");
                    table.ForeignKey(
                        name: "FK_NotaEntrada_Usuario_loginUsuarioResponsavel",
                        column: x => x.loginUsuarioResponsavel,
                        principalTable: "Usuario",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FornecedorProduto",
                columns: table => new
                {
                    FornecedorNome = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProdutosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorProduto", x => new { x.FornecedorNome, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_FornecedorProduto_Fornecedor_FornecedorNome",
                        column: x => x.FornecedorNome,
                        principalTable: "Fornecedor",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FornecedorProduto_Produto_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemSaida",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    NotaSaidaId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSaida", x => new { x.NotaSaidaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ItemSaida_NotaSaida_NotaSaidaId",
                        column: x => x.NotaSaidaId,
                        principalTable: "NotaSaida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSaida_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnidadeMedida",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    descricao = table.Column<string>(type: "longtext", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeMedida", x => x.id);
                    table.ForeignKey(
                        name: "FK_UnidadeMedida_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemEntrada",
                columns: table => new
                {
                    NotaEntradaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemEntrada", x => new { x.NotaEntradaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ItemEntrada_NotaEntrada_NotaEntradaId",
                        column: x => x.NotaEntradaId,
                        principalTable: "NotaEntrada",
                        principalColumn: "IdNotaEntrada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemEntrada_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FornecedorProduto_ProdutosId",
                table: "FornecedorProduto",
                column: "ProdutosId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemEntrada_ProdutoId",
                table: "ItemEntrada",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSaida_ProdutoId",
                table: "ItemSaida",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaEntrada_FornecedorNome",
                table: "NotaEntrada",
                column: "FornecedorNome");

            migrationBuilder.CreateIndex(
                name: "IX_NotaEntrada_loginUsuarioResponsavel",
                table: "NotaEntrada",
                column: "loginUsuarioResponsavel");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_UnidadeMediaId",
                table: "Produto",
                column: "UnidadeMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeMedida_ProdutoId",
                table: "UnidadeMedida",
                column: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FornecedorProduto");

            migrationBuilder.DropTable(
                name: "ItemEntrada");

            migrationBuilder.DropTable(
                name: "ItemSaida");

            migrationBuilder.DropTable(
                name: "UnidadeMedida");

            migrationBuilder.DropTable(
                name: "NotaEntrada");

            migrationBuilder.DropTable(
                name: "NotaSaida");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
