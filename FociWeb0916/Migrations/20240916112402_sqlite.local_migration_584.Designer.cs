﻿// <auto-generated />
using FociWeb0916.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FociWeb0916.Migrations
{
    [DbContext(typeof(FociDBContext))]
    [Migration("20240916112402_sqlite.local_migration_584")]
    partial class sqlitelocal_migration_584
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("FociWeb0916.Models.Meccs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fordulo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HazaiCsapat")
                        .HasColumnType("TEXT");

                    b.Property<int>("HazaiFel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hazaiveg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VendegCsapat")
                        .HasColumnType("TEXT");

                    b.Property<int>("VendegFel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vendegveg")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Meccs");
                });
#pragma warning restore 612, 618
        }
    }
}
