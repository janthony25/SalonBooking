﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalonBooking.Data;

#nullable disable

namespace SalonBooking.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250214211853_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalonBooking.Models.BusinessDay", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"));

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.HasKey("DayId");

                    b.ToTable("BusinessDays");

                    b.HasData(
                        new
                        {
                            DayId = 1,
                            DayName = "Monday",
                            IsOpen = true
                        },
                        new
                        {
                            DayId = 2,
                            DayName = "Tuesday",
                            IsOpen = true
                        },
                        new
                        {
                            DayId = 3,
                            DayName = "Wednesday",
                            IsOpen = true
                        },
                        new
                        {
                            DayId = 4,
                            DayName = "Thursday",
                            IsOpen = true
                        },
                        new
                        {
                            DayId = 5,
                            DayName = "Friday",
                            IsOpen = true
                        },
                        new
                        {
                            DayId = 6,
                            DayName = "Saturday",
                            IsOpen = true
                        },
                        new
                        {
                            DayId = 7,
                            DayName = "Sunday",
                            IsOpen = true
                        });
                });

            modelBuilder.Entity("SalonBooking.Models.SpecialClosure", b =>
                {
                    b.Property<int>("ClosureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClosureId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClosureId");

                    b.ToTable("SpecialClosures");
                });
#pragma warning restore 612, 618
        }
    }
}
