﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppOglas.Models;

#nullable disable

namespace WebAppOglas.Migrations
{
    [DbContext(typeof(MvcOglasContext))]
    [Migration("20230824164241_MigrationInc")]
    partial class MigrationInc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppOglas.Models.Automobil", b =>
                {
                    b.Property<int>("IdAutomobil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idAutomobil");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutomobil"));

                    b.Property<int>("Cena")
                        .HasColumnType("int")
                        .HasColumnName("cena");

                    b.Property<string>("Fotografija")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("fotografija");

                    b.Property<int?>("Godiste")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("godiste");

                    b.Property<string>("Gorivo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("gorivo");

                    b.Property<string>("Karoserija")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("karoserija");

                    b.Property<int>("Kontakt")
                        .HasColumnType("int")
                        .HasColumnName("kontakt");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("marka");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("opis");

                    b.Property<int>("Snaga")
                        .HasColumnType("int")
                        .HasColumnName("snaga");

                    b.Property<int>("ZapreminaMotora")
                        .HasColumnType("int")
                        .HasColumnName("zapremina_motora");

                    b.HasKey("IdAutomobil");

                    b.ToTable("Automobil");
                });
#pragma warning restore 612, 618
        }
    }
}
