﻿// <auto-generated />
using EstudioAnime.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EstudioAnimes.Migrations
{
    [DbContext(typeof(OracleFIAPDbContext))]
    [Migration("20240423002026_CreateDiretores_Estudios")]
    partial class CreateDiretores_Estudios
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EstudioAnime.Models.Animadores", b =>
                {
                    b.Property<int>("AnimadoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimadoresId"));

                    b.Property<int>("AnosExperiencia")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EstiloAnimacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("AnimadoresId");

                    b.ToTable("98874_Animadores");
                });

            modelBuilder.Entity("EstudioAnime.Models.Animes", b =>
                {
                    b.Property<int>("AnimesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimesId"));

                    b.Property<string>("DataLancamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("QuantidadeEp")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("AnimesId");

                    b.ToTable("98874_Animes");
                });

            modelBuilder.Entity("EstudioAnime.Models.Diretores", b =>
                {
                    b.Property<int>("DiretoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiretoresId"));

                    b.Property<string>("Especializacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ProjetosConcluidos")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("DiretoresId");

                    b.ToTable("98874_Diretores");
                });

            modelBuilder.Entity("EstudioAnime.Models.Estudios", b =>
                {
                    b.Property<int>("EstudiosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstudiosId"));

                    b.Property<string>("DataFundação")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NomeEstudio")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EstudiosId");

                    b.ToTable("98874_Estudios");
                });
#pragma warning restore 612, 618
        }
    }
}
