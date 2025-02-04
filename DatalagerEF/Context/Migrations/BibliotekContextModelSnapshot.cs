﻿// <auto-generated />
using System;
using DatalagerEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatalagerEF.Context.Migrations
{
    [DbContext(typeof(BibliotekContext))]
    partial class BibliotekContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntitetsLager.Bok", b =>
                {
                    b.Property<int>("BokId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Bokningsnummer")
                        .HasColumnType("int");

                    b.Property<string>("Boktitel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ISPN")
                        .HasColumnType("int");

                    b.Property<bool>("Tillgänglig")
                        .HasColumnType("bit");

                    b.HasKey("BokId");

                    b.HasIndex("Bokningsnummer");

                    b.ToTable("Böcker");
                });

            modelBuilder.Entity("EntitetsLager.BokBokning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BokId")
                        .HasColumnType("int");

                    b.Property<int>("BokningId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BokId");

                    b.HasIndex("BokningId");

                    b.ToTable("BokBokning");
                });

            modelBuilder.Entity("EntitetsLager.Bokning", b =>
                {
                    b.Property<int>("Bokningsnummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktiv")
                        .HasColumnType("bit");

                    b.Property<int?>("MedlemsNummer")
                        .HasColumnType("int");

                    b.Property<DateTime>("Utlämningsdatum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Återlämningsdatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Bokningsnummer");

                    b.HasIndex("MedlemsNummer");

                    b.ToTable("Bokningar");
                });

            modelBuilder.Entity("EntitetsLager.Expedit", b =>
                {
                    b.Property<int>("Anställningsnummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lösenord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roll")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Anställningsnummer");

                    b.ToTable("Expediter");
                });

            modelBuilder.Entity("EntitetsLager.Faktura", b =>
                {
                    b.Property<int>("Fakturanummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bokningsnummer")
                        .HasColumnType("int");

                    b.Property<DateTime>("FaktisktÅterlämningsdatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Totalpris")
                        .HasColumnType("int");

                    b.HasKey("Fakturanummer");

                    b.ToTable("Fakturor");
                });

            modelBuilder.Entity("EntitetsLager.Medlem", b =>
                {
                    b.Property<int>("MedlemsNummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Epostadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefonnummer")
                        .HasColumnType("int");

                    b.HasKey("MedlemsNummer");

                    b.ToTable("Medlemmar");
                });

            modelBuilder.Entity("EntitetsLager.Bok", b =>
                {
                    b.HasOne("EntitetsLager.Bokning", null)
                        .WithMany("Bok")
                        .HasForeignKey("Bokningsnummer");
                });

            modelBuilder.Entity("EntitetsLager.BokBokning", b =>
                {
                    b.HasOne("EntitetsLager.Bok", "Bok")
                        .WithMany("BokBokningar")
                        .HasForeignKey("BokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntitetsLager.Bokning", "Bokning")
                        .WithMany("BokBokningar")
                        .HasForeignKey("BokningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntitetsLager.Bokning", b =>
                {
                    b.HasOne("EntitetsLager.Medlem", "Medlemsnummer")
                        .WithMany()
                        .HasForeignKey("MedlemsNummer");
                });
#pragma warning restore 612, 618
        }
    }
}
