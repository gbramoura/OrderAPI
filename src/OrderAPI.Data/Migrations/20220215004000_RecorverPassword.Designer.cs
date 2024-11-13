﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderAPI.Data;

namespace OrderAPI.Data.Migrations
{
    [DbContext(typeof(OrderAPIContext))]
    [Migration("20220215004000_RecorverPassword")]
    partial class RecorverPassword
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("OrderAPI.Domain.Models.CategoriaModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(245)
                        .HasColumnType("varchar(245)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Codigo");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ControleEstoqueModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime");

                    b.Property<int>("FuncionarioCodigo")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasMaxLength(245)
                        .HasColumnType("varchar(245)");

                    b.Property<int>("ProdutoCodigo")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("FuncionarioCodigo");

                    b.HasIndex("ProdutoCodigo");

                    b.ToTable("ControleEstoque");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.FavoritoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProdutoCodigo")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("UsuarioCodigo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("ProdutoCodigo");

                    b.HasIndex("UsuarioCodigo");

                    b.ToTable("Favorito");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(245)
                        .HasColumnType("varchar(245)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(115)
                        .HasColumnType("varchar(115)");

                    b.Property<int>("Previlegio")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<byte[]>("Token")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Codigo");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ImageModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Caminho")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Extensao")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<int>("ProductCodigo")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.HasKey("Codigo");

                    b.HasIndex("ProductCodigo")
                        .IsUnique();

                    b.ToTable("Image");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.MetodoPagamentoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Codigo");

                    b.ToTable("MetodoPagamento");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.PedidoItemModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PedidoCodigo")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoCodigo")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("PedidoCodigo");

                    b.HasIndex("ProdutoCodigo");

                    b.ToTable("PedidoItem");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.PedidoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime");

                    b.Property<int>("MetodoPagamentoCodigo")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasMaxLength(245)
                        .HasColumnType("varchar(245)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCodigo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("MetodoPagamentoCodigo");

                    b.HasIndex("UsuarioCodigo");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaCodigo")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(245)
                        .HasColumnType("varchar(245)");

                    b.Property<int>("ImageCodigo")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("CategoriaCodigo");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.RecoverPasswordModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.HasKey("Codigo");

                    b.ToTable("RecoverPassword");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.TokenModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("Actor")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.HasKey("Codigo");

                    b.ToTable("Token");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(245)
                        .HasColumnType("varchar(245)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(115)
                        .HasColumnType("varchar(115)");

                    b.Property<string>("Prontuario")
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(145)
                        .HasColumnType("varchar(145)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<byte[]>("Token")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Codigo");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ControleEstoqueModel", b =>
                {
                    b.HasOne("OrderAPI.Domain.Models.FuncionarioModel", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderAPI.Domain.Models.ProdutoModel", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.FavoritoModel", b =>
                {
                    b.HasOne("OrderAPI.Domain.Models.ProdutoModel", "Produto")
                        .WithMany("Favoritos")
                        .HasForeignKey("ProdutoCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderAPI.Domain.Models.UsuarioModel", "Usuario")
                        .WithMany("Favoritos")
                        .HasForeignKey("UsuarioCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ImageModel", b =>
                {
                    b.HasOne("OrderAPI.Domain.Models.ProdutoModel", "Produto")
                        .WithOne("Imagem")
                        .HasForeignKey("OrderAPI.Domain.Models.ImageModel", "ProductCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.PedidoItemModel", b =>
                {
                    b.HasOne("OrderAPI.Domain.Models.PedidoModel", "Pedido")
                        .WithMany("Items")
                        .HasForeignKey("PedidoCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderAPI.Domain.Models.ProdutoModel", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.PedidoModel", b =>
                {
                    b.HasOne("OrderAPI.Domain.Models.MetodoPagamentoModel", "MetodoPagamento")
                        .WithMany()
                        .HasForeignKey("MetodoPagamentoCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderAPI.Domain.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MetodoPagamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ProdutoModel", b =>
                {
                    b.HasOne("OrderAPI.Domain.Models.CategoriaModel", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.CategoriaModel", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.PedidoModel", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.ProdutoModel", b =>
                {
                    b.Navigation("Favoritos");

                    b.Navigation("Imagem");
                });

            modelBuilder.Entity("OrderAPI.Domain.Models.UsuarioModel", b =>
                {
                    b.Navigation("Favoritos");
                });
#pragma warning restore 612, 618
        }
    }
}
