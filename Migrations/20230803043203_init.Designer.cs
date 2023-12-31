﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sysestoque_alpha.Models;

#nullable disable

namespace sysestoque_alpha.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    [Migration("20230803043203_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FornecedorProduto", b =>
                {
                    b.Property<string>("FornecedorNome")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("FornecedorNome", "ProdutosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("FornecedorProduto");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Fornecedor", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("cnpj")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("fone")
                        .HasColumnType("longtext");

                    b.HasKey("Nome");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.ItemEntrada", b =>
                {
                    b.Property<int>("NotaEntradaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<float>("Quantidade")
                        .HasColumnType("float");

                    b.HasKey("NotaEntradaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemEntrada");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.ItemSaida", b =>
                {
                    b.Property<int>("NotaSaidaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<float>("Quantidade")
                        .HasColumnType("float");

                    b.HasKey("NotaSaidaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemSaida");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.NotaEntrada", b =>
                {
                    b.Property<int>("IdNotaEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FornecedorNome")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("float");

                    b.Property<DateTime>("dataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("loginUsuarioResponsavel")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdNotaEntrada");

                    b.HasIndex("FornecedorNome");

                    b.HasIndex("loginUsuarioResponsavel");

                    b.ToTable("NotaEntrada");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.NotaSaida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("dataSaida")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("valorTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NotaSaida");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<float>("Estoque")
                        .HasColumnType("float");

                    b.Property<float>("EstoqueMax")
                        .HasColumnType("float");

                    b.Property<float>("EstoqueMedio")
                        .HasColumnType("float");

                    b.Property<float>("EstoqueMin")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UnidadeMediaId")
                        .HasColumnType("int");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UnidadeMediaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.UnidadeMedida", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("UnidadeMedida");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Usuario", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HashSenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Login");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("FornecedorProduto", b =>
                {
                    b.HasOne("sysestoque_alpha.Models.Fornecedor", null)
                        .WithMany()
                        .HasForeignKey("FornecedorNome")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_alpha.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sysestoque_alpha.Models.ItemEntrada", b =>
                {
                    b.HasOne("sysestoque_alpha.Models.NotaEntrada", "NotaEntrada")
                        .WithMany("ItemEntrada")
                        .HasForeignKey("NotaEntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_alpha.Models.Produto", "Produto")
                        .WithMany("ItensEntrada")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaEntrada");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.ItemSaida", b =>
                {
                    b.HasOne("sysestoque_alpha.Models.NotaSaida", "NotaSaida")
                        .WithMany("ItensSaida")
                        .HasForeignKey("NotaSaidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_alpha.Models.Produto", "produto")
                        .WithMany("ItensSaida")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaSaida");

                    b.Navigation("produto");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.NotaEntrada", b =>
                {
                    b.HasOne("sysestoque_alpha.Models.Fornecedor", "Fornecedor")
                        .WithMany("NotasEntrada")
                        .HasForeignKey("FornecedorNome");

                    b.HasOne("sysestoque_alpha.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("loginUsuarioResponsavel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Produto", b =>
                {
                    b.HasOne("sysestoque_alpha.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_alpha.Models.Categoria", "UnidadeMedia")
                        .WithMany()
                        .HasForeignKey("UnidadeMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("UnidadeMedia");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.UnidadeMedida", b =>
                {
                    b.HasOne("sysestoque_alpha.Models.Produto", null)
                        .WithMany("UnidadesMedia")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Fornecedor", b =>
                {
                    b.Navigation("NotasEntrada");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.NotaEntrada", b =>
                {
                    b.Navigation("ItemEntrada");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.NotaSaida", b =>
                {
                    b.Navigation("ItensSaida");
                });

            modelBuilder.Entity("sysestoque_alpha.Models.Produto", b =>
                {
                    b.Navigation("ItensEntrada");

                    b.Navigation("ItensSaida");

                    b.Navigation("UnidadesMedia");
                });
#pragma warning restore 612, 618
        }
    }
}
