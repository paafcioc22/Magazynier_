﻿// <auto-generated />
using System;
using Magazynier.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Magazynier.DataAccess.Migrations
{
    [DbContext(typeof(WarehouseProcessesContext))]
    [Migration("20210320112846_placeschangeDataTime3")]
    partial class placeschangeDataTime3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItemPlace", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("PlacesId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "PlacesId");

                    b.HasIndex("PlacesId");

                    b.ToTable("ItemPlace");
                });

            modelBuilder.Entity("Magazynier.DataAccess.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DclMagKod")
                        .HasColumnType("int");

                    b.Property<string>("Fmm_NrListu")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Fmm_NrlistuPaczka")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Trn_DataSkan")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Trn_GidNumer")
                        .HasColumnType("int");

                    b.Property<int>("Trn_GidTyp")
                        .HasColumnType("int");

                    b.Property<string>("Trn_NrDokumentu")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("Trn_Stan")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Magazynier.DataAccess.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Price")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RaportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("RaportId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Magazynier.DataAccess.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlaceMagZrd")
                        .HasColumnType("int");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("PlaceOpis")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("PlaceTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PlaceTrnNumer")
                        .HasColumnType("int");

                    b.Property<int>("PlaceTwrNumer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("Magazynier.DataAccess.Entities.Raport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MsR_Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("MsR_Ilosc")
                        .HasColumnType("int");

                    b.Property<int>("MsR_MagNumer")
                        .HasColumnType("int");

                    b.Property<int>("MsR_NewGidNumer")
                        .HasColumnType("int");

                    b.Property<byte>("MsR_StanDok")
                        .HasColumnType("tinyint");

                    b.Property<int>("MsR_TrnNumer")
                        .HasColumnType("int");

                    b.Property<int>("MsR_TwrNumer")
                        .HasColumnType("int");

                    b.Property<int>("MsR_TypDok")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Raport");
                });

            modelBuilder.Entity("ItemPlace", b =>
                {
                    b.HasOne("Magazynier.DataAccess.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Magazynier.DataAccess.Entities.Place", null)
                        .WithMany()
                        .HasForeignKey("PlacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Magazynier.DataAccess.Entities.Item", b =>
                {
                    b.HasOne("Magazynier.DataAccess.Entities.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Magazynier.DataAccess.Entities.Raport", "Raport")
                        .WithMany("Items")
                        .HasForeignKey("RaportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("Raport");
                });

            modelBuilder.Entity("Magazynier.DataAccess.Entities.Raport", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
