﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PametniDomAPP;

#nullable disable

namespace PametniDomApplikacija.Migrations
{
    [DbContext(typeof(StockContext))]
    [Migration("20240103160117_M2")]
    partial class M2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("PametniDomAPP.Uporabnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("geslo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("uenaslov")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("uime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UporabnikDB");
                });
#pragma warning restore 612, 618
        }
    }
}