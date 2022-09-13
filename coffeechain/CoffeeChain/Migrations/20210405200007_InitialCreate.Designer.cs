﻿// <auto-generated />
using System;
using CoffeeChain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeChain.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210405200007_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Armazem", b =>
                {
                    b.Property<int>("ArmazemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CidadeArmazem")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("EmailArmazem")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("EnderecoArmazem")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("TelefoneArmazem")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("UfArmazem")
                        .HasColumnType("VARCHAR(2)");

                    b.HasKey("ArmazemId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Armazem");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJEmpresa")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("CepEmpresa")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CidadeEmpresa")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("EmailEmpresa")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("EnderecoEmpresa")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("PaisEmpresa")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("TelefoneEmpresa")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("UfEmpresa")
                        .HasColumnType("VARCHAR(2)");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Entradas", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmazemId")
                        .HasColumnType("int");

                    b.Property<string>("CodigoLote")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<decimal>("CustoEntrada")
                        .HasColumnType("DECIMAL(9)");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("DATE");

                    b.Property<string>("EmbalagemArmazenado")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("LocalArmazenado")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("NfeEntrada")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<decimal>("PrecoLote")
                        .HasColumnType("DECIMAL(9)");

                    b.Property<int>("ProdutorId")
                        .HasColumnType("int");

                    b.Property<int>("PropriedadeId")
                        .HasColumnType("int");

                    b.Property<decimal>("QtdSacas")
                        .HasColumnType("DECIMAL(9)");

                    b.Property<string>("Safra")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("TipoCafe")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("TipoEntrada")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntradaId");

                    b.HasIndex("ArmazemId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ProdutorId");

                    b.HasIndex("PropriedadeId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Produtor", b =>
                {
                    b.Property<int>("ProdutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CepProdutor")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("CidadeProdutor")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("CpfProdutor")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("EmailProdutor")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("EnderecoProdutor")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeProdutor")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("RgProdutor")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("TelefoneProdutor")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("UfProdutor")
                        .HasColumnType("VARCHAR(2)");

                    b.HasKey("ProdutorId");

                    b.ToTable("Produtor");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Propriedade", b =>
                {
                    b.Property<int>("PropriedadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJFazenda")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("CepPropriedade")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("CidadePropriedade")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("EmailPropriedade")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("EnderecoPropriedade")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("InscEstadual")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("NomeFazenda")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("ProdutorId")
                        .HasColumnType("int");

                    b.Property<string>("TelefonePropriedade")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("UfPropriedade")
                        .HasColumnType("VARCHAR(2)");

                    b.HasKey("PropriedadeId");

                    b.HasIndex("ProdutorId");

                    b.ToTable("Propriedade");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Saidas", b =>
                {
                    b.Property<int>("SaidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CustoSaida")
                        .HasColumnType("DECIMAL(9)");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("DATE");

                    b.Property<int>("DestinoArmazemId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoEmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoProdutorId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoPropriedadeId")
                        .HasColumnType("int");

                    b.Property<string>("EmbalagemSaida")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.Property<string>("NfeSaida")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal>("PrecoSaida")
                        .HasColumnType("DECIMAL(9)");

                    b.Property<decimal>("QtdSacas")
                        .HasColumnType("DECIMAL(9)");

                    b.Property<int>("TipoSaida")
                        .HasColumnType("INTEGER");

                    b.HasKey("SaidaId");

                    b.HasIndex("DestinoArmazemId");

                    b.HasIndex("DestinoEmpresaId");

                    b.HasIndex("DestinoProdutorId");

                    b.HasIndex("DestinoPropriedadeId");

                    b.HasIndex("EntradaId");

                    b.ToTable("Saidas");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Armazem", b =>
                {
                    b.HasOne("CoffeeChain.Domain.Entities.Empresa", "Empresa")
                        .WithMany("Armazens")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Entradas", b =>
                {
                    b.HasOne("CoffeeChain.Domain.Entities.Armazem", "Armazem")
                        .WithMany("Entradas")
                        .HasForeignKey("ArmazemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Empresa", "Empresa")
                        .WithMany("Entradas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Produtor", "Produtor")
                        .WithMany("Entradas")
                        .HasForeignKey("ProdutorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Propriedade", "Propriedade")
                        .WithMany("Entradas")
                        .HasForeignKey("PropriedadeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Armazem");

                    b.Navigation("Empresa");

                    b.Navigation("Produtor");

                    b.Navigation("Propriedade");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Propriedade", b =>
                {
                    b.HasOne("CoffeeChain.Domain.Entities.Produtor", "Produtor")
                        .WithMany("Propriedades")
                        .HasForeignKey("ProdutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produtor");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Saidas", b =>
                {
                    b.HasOne("CoffeeChain.Domain.Entities.Armazem", "Armazem")
                        .WithMany("Saidas")
                        .HasForeignKey("DestinoArmazemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Empresa", "Empresa")
                        .WithMany("Saidas")
                        .HasForeignKey("DestinoEmpresaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Produtor", "Produtor")
                        .WithMany("Saidas")
                        .HasForeignKey("DestinoProdutorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Propriedade", "Propriedade")
                        .WithMany("Saidas")
                        .HasForeignKey("DestinoPropriedadeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoffeeChain.Domain.Entities.Entradas", "Entradas")
                        .WithMany("Saidas")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Armazem");

                    b.Navigation("Empresa");

                    b.Navigation("Entradas");

                    b.Navigation("Produtor");

                    b.Navigation("Propriedade");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Armazem", b =>
                {
                    b.Navigation("Entradas");

                    b.Navigation("Saidas");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Empresa", b =>
                {
                    b.Navigation("Armazens");

                    b.Navigation("Entradas");

                    b.Navigation("Saidas");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Entradas", b =>
                {
                    b.Navigation("Saidas");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Produtor", b =>
                {
                    b.Navigation("Entradas");

                    b.Navigation("Propriedades");

                    b.Navigation("Saidas");
                });

            modelBuilder.Entity("CoffeeChain.Domain.Entities.Propriedade", b =>
                {
                    b.Navigation("Entradas");

                    b.Navigation("Saidas");
                });
#pragma warning restore 612, 618
        }
    }
}
