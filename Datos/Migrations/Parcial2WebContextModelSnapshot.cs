﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(Parcial2WebContext))]
    partial class Parcial2WebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Persona", b =>
                {
                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstitucionEducativa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreAcudiente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identificacion");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Entity.Vacuna", b =>
                {
                    b.Property<string>("Identificacionv")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EdadVacuna")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeNacimientov")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVacuna")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstitucionEducativav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreAcudientev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreVacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombrev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeDocumentov")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identificacionv");

                    b.ToTable("vacunas");
                });
#pragma warning restore 612, 618
        }
    }
}