﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using br.com.paype.Data;

namespace br.com.paype.Migrations
{
    [DbContext(typeof(DataContextDB))]
    [Migration("20210924205843_initial_migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("br.com.paype.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("br.com.paype.Models.Fiscal.Empresa", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificadoDigital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegimeEstadualHandle")
                        .HasColumnType("int");

                    b.Property<int>("RegimeFederalHandle")
                        .HasColumnType("int");

                    b.Property<string>("SenhaCertificado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VencimentoCertificado")
                        .HasColumnType("datetime2");

                    b.HasKey("Handle");

                    b.HasIndex("RegimeEstadualHandle");

                    b.HasIndex("RegimeFederalHandle");

                    b.ToTable("FS_EMPRESA");
                });

            modelBuilder.Entity("br.com.paype.Models.Fiscal.EmpresaRegime", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Handle");

                    b.ToTable("FS_EMPRESAREGIME");
                });

            modelBuilder.Entity("br.com.paype.Models.Fiscal.Pessoa", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoriaRNTRC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cliente")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dependentes")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fornecedor")
                        .HasColumnType("bit");

                    b.Property<bool>("Funcionário")
                        .HasColumnType("bit");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Motorista")
                        .HasColumnType("bit");

                    b.Property<string>("Naturalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgaoEmissor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RNTRC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Razao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Transportador")
                        .HasColumnType("bit");

                    b.HasKey("Handle");

                    b.ToTable("FS_PESSOA");
                });

            modelBuilder.Entity("br.com.paype.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("br.com.paype.Models.ProductImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.Papel", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissaoHandle")
                        .HasColumnType("int");

                    b.Property<string>("Policy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Handle");

                    b.HasIndex("PermissaoHandle");

                    b.ToTable("TI_PAPEL");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.PapelUsuario", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PapelHandle")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioHandle")
                        .HasColumnType("int");

                    b.HasKey("Handle");

                    b.HasIndex("PapelHandle");

                    b.HasIndex("UsuarioHandle");

                    b.ToTable("TI_PAPEL_USUARIO");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.Perfil", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Handle");

                    b.ToTable("TI_PERFIL");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.PerfilPapel", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PapelHandle")
                        .HasColumnType("int");

                    b.Property<int>("PerfilHandle")
                        .HasColumnType("int");

                    b.HasKey("Handle");

                    b.HasIndex("PapelHandle");

                    b.HasIndex("PerfilHandle");

                    b.ToTable("TI_PERFIL_PAPEL");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.Permissao", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Handle");

                    b.ToTable("TI_PERMISSAO");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.Usuario", b =>
                {
                    b.Property<int>("Handle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Handle");

                    b.ToTable("TI_USUARIO");
                });

            modelBuilder.Entity("br.com.paype.Models.Fiscal.Empresa", b =>
                {
                    b.HasOne("br.com.paype.Models.Fiscal.EmpresaRegime", "RegimeEstadual")
                        .WithMany()
                        .HasForeignKey("RegimeEstadualHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("br.com.paype.Models.Fiscal.EmpresaRegime", "RegimeFederal")
                        .WithMany()
                        .HasForeignKey("RegimeFederalHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegimeEstadual");

                    b.Navigation("RegimeFederal");
                });

            modelBuilder.Entity("br.com.paype.Models.Product", b =>
                {
                    b.HasOne("br.com.paype.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("br.com.paype.Models.ProductImages", b =>
                {
                    b.HasOne("br.com.paype.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.Papel", b =>
                {
                    b.HasOne("br.com.paype.Models.TI.Permissao", "Permissao")
                        .WithMany()
                        .HasForeignKey("PermissaoHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permissao");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.PapelUsuario", b =>
                {
                    b.HasOne("br.com.paype.Models.TI.Papel", "Papel")
                        .WithMany()
                        .HasForeignKey("PapelHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("br.com.paype.Models.TI.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Papel");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("br.com.paype.Models.TI.PerfilPapel", b =>
                {
                    b.HasOne("br.com.paype.Models.TI.Papel", "Papel")
                        .WithMany()
                        .HasForeignKey("PapelHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("br.com.paype.Models.TI.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilHandle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Papel");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("br.com.paype.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("br.com.paype.Models.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}