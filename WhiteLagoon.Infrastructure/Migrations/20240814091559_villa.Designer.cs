﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhiteLagoon.Infrastructure.Data;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240814091559_villa")]
    partial class villa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Villa 1 Description",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Villa 1",
                            Occupancy = 5,
                            Price = 100.0,
                            Sqft = 1000,
                            Updated_Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Created_Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Villa 2 Description",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Villa 2",
                            Occupancy = 10,
                            Price = 200.0,
                            Sqft = 2000,
                            Updated_Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.VillaNumber", b =>
                {
                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Villa_Number");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            Villa_Number = 101,
                            SpecialDetails = "Special Details for Villa 1",
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 102,
                            SpecialDetails = "Special Details for Villa 2",
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 103,
                            SpecialDetails = "Special Details for Villa 1",
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 201,
                            SpecialDetails = "Special Details for Villa 2",
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 202,
                            SpecialDetails = "Special Details for Villa 2",
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 203,
                            SpecialDetails = "Special Details for Villa 2",
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 301,
                            SpecialDetails = "Special Details for Villa 2",
                            VillaId = 3
                        },
                        new
                        {
                            Villa_Number = 302,
                            SpecialDetails = "Special Details for Villa 2",
                            VillaId = 3
                        });
                });

            modelBuilder.Entity("WhiteLagoon.Domain.Entities.VillaNumber", b =>
                {
                    b.HasOne("WhiteLagoon.Domain.Entities.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
