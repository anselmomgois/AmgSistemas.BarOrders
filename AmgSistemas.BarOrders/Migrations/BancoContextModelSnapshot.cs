﻿// <auto-generated />
using System;
using AmgSistemas.BarOrders.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmgSistemas.BarOrders.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TCOMANDA", b =>
                {
                    b.Property<string>("ID_COMANDA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COD_COMANDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_ESTADO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_MESA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_MESA_ATENDENTE")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_COMANDA");

                    b.HasIndex("ID_FILIAL");

                    b.HasIndex("ID_MESA");

                    b.HasIndex("ID_MESA_ATENDENTE");

                    b.ToTable("AGBO_TCOMANDA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TEMPRESA", b =>
                {
                    b.Property<string>("ID_EMPRESA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_ACTIVO")
                        .HasColumnType("bit");

                    b.Property<byte[]>("BOL_IMAGEM")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("COD_EMPRESA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_EMPRESA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.HasKey("ID_EMPRESA");

                    b.ToTable("AGBO_TEMPRESA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", b =>
                {
                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_ACTIVO")
                        .HasColumnType("bit");

                    b.Property<bool>("BOL_SOLICITAR_TELEFONE")
                        .HasColumnType("bit");

                    b.Property<bool>("BOL_TRABALHA_POR_MESA")
                        .HasColumnType("bit");

                    b.Property<string>("COD_FILIAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_PREFIXO_COMANDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_FILIAL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_EMPRESA")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_FILIAL");

                    b.HasIndex("ID_EMPRESA");

                    b.ToTable("AGBO_TFILIAL");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL_FUNCIONARIO", b =>
                {
                    b.Property<string>("ID_FILIAL_FUNCIONARIO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_FUNCIONARIO")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_FILIAL_FUNCIONARIO");

                    b.HasIndex("ID_FILIAL");

                    b.HasIndex("ID_FUNCIONARIO");

                    b.ToTable("AGBO_TFILIAL_FUNCIONARIO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFUNCIONARIO", b =>
                {
                    b.Property<string>("ID_FUNCIONARIO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_ATIVO")
                        .HasColumnType("bit");

                    b.Property<string>("COD_FUNCIONARIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_TIPO_FUNCIONARIO")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_FUNCIONARIO");

                    b.HasIndex("ID_TIPO_FUNCIONARIO");

                    b.ToTable("AGBO_TFUNCIONARIO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TGRUPO_PRODUTO", b =>
                {
                    b.Property<string>("ID_GRUPO_PRODUTO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COD_GRUPO_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_GRUPO_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_EMPRESA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_GRUPO_PRODUTO_PAI")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_GRUPO_PRODUTO");

                    b.HasIndex("ID_EMPRESA");

                    b.HasIndex("ID_GRUPO_PRODUTO_PAI");

                    b.ToTable("AGBO_TGRUPO_PRODUTO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TITEM_COMANDA", b =>
                {
                    b.Property<string>("ID_ITEM_COMANDA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_COMANDA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_PRODUTO_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("NUM_QUANTIDADE")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_ITEM_COMANDA");

                    b.HasIndex("ID_COMANDA");

                    b.HasIndex("ID_PRODUTO_FILIAL");

                    b.ToTable("AGBO_TITEM_COMANDA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA", b =>
                {
                    b.Property<string>("ID_MESA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_ATIVO")
                        .HasColumnType("bit");

                    b.Property<string>("COD_ESTADO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_MESA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_MESA");

                    b.HasIndex("ID_FILIAL");

                    b.ToTable("AGBO_TMESA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA_ATENDENTE", b =>
                {
                    b.Property<string>("ID_MESA_ATENDENTE")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_CORRENTE")
                        .HasColumnType("bit");

                    b.Property<string>("COD_CHAVE_ACESSO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_COMANDA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_TELEFONE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_FUNCIONARIO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_MESA")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_MESA_ATENDENTE");

                    b.HasIndex("ID_FILIAL");

                    b.HasIndex("ID_FUNCIONARIO");

                    b.HasIndex("ID_MESA");

                    b.ToTable("AGBO_TMESA_ATENDENTE");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPARAMETROS", b =>
                {
                    b.Property<string>("ID_PARAMETRO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_ACTIVO")
                        .HasColumnType("bit");

                    b.Property<string>("COD_PARAMETRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_TIPO_PARAMETRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_PARAMETRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.HasKey("ID_PARAMETRO");

                    b.ToTable("AGBO_TPARAMETROS");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPARAMETRO_VALOR", b =>
                {
                    b.Property<string>("ID_PARAMETRO_VALOR")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DES_VALOR_PARAMETRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_REGISTRO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_EMPRESA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_PARAMETRO")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID_PARAMETRO_VALOR");

                    b.HasIndex("ID_EMPRESA");

                    b.HasIndex("ID_FILIAL");

                    b.HasIndex("ID_PARAMETRO");

                    b.ToTable("AGBO_TPARAMETRO_VALOR");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO", b =>
                {
                    b.Property<string>("ID_PRODUTO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BOL_ACTIVO")
                        .HasColumnType("bit");

                    b.Property<byte[]>("BOL_IMAGEM")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("COD_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DTH_PRODUTO")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_EMPRESA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_GRUPO_PRODUTO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OBS_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_PRODUTO");

                    b.HasIndex("ID_EMPRESA");

                    b.HasIndex("ID_GRUPO_PRODUTO");

                    b.ToTable("AGBO_TPRODUTO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO_FILIAL", b =>
                {
                    b.Property<string>("ID_PRODUTO_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AGBO_TPRODUTOID_PRODUTO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_FILIAL")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ID_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NUM_QUANTIDADE")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NUM_VALOR")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_PRODUTO_FILIAL");

                    b.HasIndex("AGBO_TPRODUTOID_PRODUTO");

                    b.HasIndex("ID_FILIAL");

                    b.ToTable("AGBO_TPRODUTO_FILIAL");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TTIPO_FUNCIONARIO", b =>
                {
                    b.Property<string>("ID_TIPO_FUNCIONARIO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COD_TIPO_FUNCIONARIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DES_TIPO_FUNCIONARIO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_TIPO_FUNCIONARIO");

                    b.ToTable("AGBO_TTIPO_FUNCIONARIO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TCOMANDA", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", "AGBO_TFILIAL")
                        .WithMany("AGBO_TCOMANDA")
                        .HasForeignKey("ID_FILIAL");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA", "AGBO_TMESA")
                        .WithMany("AGBO_TCOMANDA")
                        .HasForeignKey("ID_MESA");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA_ATENDENTE", "AGBO_TMESA_ATENDENTE")
                        .WithMany("AGBO_TCOMANDA")
                        .HasForeignKey("ID_MESA_ATENDENTE");

                    b.Navigation("AGBO_TFILIAL");

                    b.Navigation("AGBO_TMESA");

                    b.Navigation("AGBO_TMESA_ATENDENTE");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TEMPRESA", "AGBO_TEMPRESA")
                        .WithMany("AGBO_TFILIAL")
                        .HasForeignKey("ID_EMPRESA");

                    b.Navigation("AGBO_TEMPRESA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL_FUNCIONARIO", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", "AGBO_TFILIAL")
                        .WithMany("AGBO_TFILIAL_FUNCIONARIO")
                        .HasForeignKey("ID_FILIAL");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFUNCIONARIO", "AGBO_TFUNCIONARIO")
                        .WithMany("AGBO_TFILIAL_FUNCIONARIO")
                        .HasForeignKey("ID_FUNCIONARIO");

                    b.Navigation("AGBO_TFILIAL");

                    b.Navigation("AGBO_TFUNCIONARIO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFUNCIONARIO", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TTIPO_FUNCIONARIO", "AGBO_TTIPO_FUNCIONARIO")
                        .WithMany("AGBO_TFUNCIONARIO")
                        .HasForeignKey("ID_TIPO_FUNCIONARIO");

                    b.Navigation("AGBO_TTIPO_FUNCIONARIO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TGRUPO_PRODUTO", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TEMPRESA", "AGBO_TEMPRESA")
                        .WithMany("AGBO_TGRUPO_PRODUTO")
                        .HasForeignKey("ID_EMPRESA");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TGRUPO_PRODUTO", "AGBO_TGRUPO_PRODUTO1")
                        .WithMany("AGBO_TGRUPO_PRODUTO2")
                        .HasForeignKey("ID_GRUPO_PRODUTO_PAI");

                    b.Navigation("AGBO_TEMPRESA");

                    b.Navigation("AGBO_TGRUPO_PRODUTO1");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TITEM_COMANDA", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TCOMANDA", "AGBO_TCOMANDA")
                        .WithMany("AGBO_TITEM_COMANDA")
                        .HasForeignKey("ID_COMANDA");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO_FILIAL", "AGBO_TPRODUTO_FILIAL")
                        .WithMany("AGBO_TITEM_COMANDA")
                        .HasForeignKey("ID_PRODUTO_FILIAL");

                    b.Navigation("AGBO_TCOMANDA");

                    b.Navigation("AGBO_TPRODUTO_FILIAL");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", "AGBO_TFILIAL")
                        .WithMany("AGBO_TMESA")
                        .HasForeignKey("ID_FILIAL");

                    b.Navigation("AGBO_TFILIAL");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA_ATENDENTE", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", "AGBO_TFILIAL")
                        .WithMany("AGBO_TMESA_ATENDENTE")
                        .HasForeignKey("ID_FILIAL");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFUNCIONARIO", "AGBO_TFUNCIONARIO")
                        .WithMany("AGBO_TMESA_ATENDENTE")
                        .HasForeignKey("ID_FUNCIONARIO");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA", "AGBO_TMESA")
                        .WithMany("AGBO_TMESA_ATENDENTE")
                        .HasForeignKey("ID_MESA");

                    b.Navigation("AGBO_TFILIAL");

                    b.Navigation("AGBO_TFUNCIONARIO");

                    b.Navigation("AGBO_TMESA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPARAMETRO_VALOR", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TEMPRESA", "AGBO_TEMPRESA")
                        .WithMany("AGBO_TPARAMETRO_VALOR")
                        .HasForeignKey("ID_EMPRESA");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", "AGBO_TFILIAL")
                        .WithMany("AGBO_TPARAMETRO_VALOR")
                        .HasForeignKey("ID_FILIAL");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TPARAMETROS", "AGBO_TPARAMETROS")
                        .WithMany("AGBO_TPARAMETRO_VALOR")
                        .HasForeignKey("ID_PARAMETRO");

                    b.Navigation("AGBO_TEMPRESA");

                    b.Navigation("AGBO_TFILIAL");

                    b.Navigation("AGBO_TPARAMETROS");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TEMPRESA", "AGBO_TEMPRESA")
                        .WithMany("AGBO_TPRODUTO")
                        .HasForeignKey("ID_EMPRESA");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TGRUPO_PRODUTO", "AGBO_TGRUPO_PRODUTO")
                        .WithMany("AGBO_TPRODUTO")
                        .HasForeignKey("ID_GRUPO_PRODUTO");

                    b.Navigation("AGBO_TEMPRESA");

                    b.Navigation("AGBO_TGRUPO_PRODUTO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO_FILIAL", b =>
                {
                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO", "AGBO_TPRODUTO")
                        .WithMany("AGBO_TPRODUTO_FILIAL")
                        .HasForeignKey("AGBO_TPRODUTOID_PRODUTO");

                    b.HasOne("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", "AGBO_TFILIAL")
                        .WithMany("AGBO_TPRODUTO_FILIAL")
                        .HasForeignKey("ID_FILIAL");

                    b.Navigation("AGBO_TFILIAL");

                    b.Navigation("AGBO_TPRODUTO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TCOMANDA", b =>
                {
                    b.Navigation("AGBO_TITEM_COMANDA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TEMPRESA", b =>
                {
                    b.Navigation("AGBO_TFILIAL");

                    b.Navigation("AGBO_TGRUPO_PRODUTO");

                    b.Navigation("AGBO_TPARAMETRO_VALOR");

                    b.Navigation("AGBO_TPRODUTO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFILIAL", b =>
                {
                    b.Navigation("AGBO_TCOMANDA");

                    b.Navigation("AGBO_TFILIAL_FUNCIONARIO");

                    b.Navigation("AGBO_TMESA");

                    b.Navigation("AGBO_TMESA_ATENDENTE");

                    b.Navigation("AGBO_TPARAMETRO_VALOR");

                    b.Navigation("AGBO_TPRODUTO_FILIAL");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TFUNCIONARIO", b =>
                {
                    b.Navigation("AGBO_TFILIAL_FUNCIONARIO");

                    b.Navigation("AGBO_TMESA_ATENDENTE");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TGRUPO_PRODUTO", b =>
                {
                    b.Navigation("AGBO_TGRUPO_PRODUTO2");

                    b.Navigation("AGBO_TPRODUTO");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA", b =>
                {
                    b.Navigation("AGBO_TCOMANDA");

                    b.Navigation("AGBO_TMESA_ATENDENTE");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TMESA_ATENDENTE", b =>
                {
                    b.Navigation("AGBO_TCOMANDA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPARAMETROS", b =>
                {
                    b.Navigation("AGBO_TPARAMETRO_VALOR");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO", b =>
                {
                    b.Navigation("AGBO_TPRODUTO_FILIAL");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TPRODUTO_FILIAL", b =>
                {
                    b.Navigation("AGBO_TITEM_COMANDA");
                });

            modelBuilder.Entity("AmgSistemas.BarOrders.BD.Models.AGBO_TTIPO_FUNCIONARIO", b =>
                {
                    b.Navigation("AGBO_TFUNCIONARIO");
                });
#pragma warning restore 612, 618
        }
    }
}
