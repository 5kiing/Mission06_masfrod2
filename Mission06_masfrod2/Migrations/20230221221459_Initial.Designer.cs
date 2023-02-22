﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_masfrod2.Models;

namespace Mission06_masfrod2.Migrations
{
    [DbContext(typeof(AddMovieContext))]
    [Migration("20230221221459_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_masfrod2.Models.AddMovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 3,
                            Director = "Boaz Yakin",
                            Edited = false,
                            LentTo = "Wife",
                            Notes = "Best Movie Ever",
                            Rating = "PG",
                            Title = "Remeber the Titans",
                            Year = (ushort)2000
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "Gore Verbinski",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Pirates of the Caribbean",
                            Year = (ushort)2003
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 4,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Interstellar",
                            Year = (ushort)2014
                        });
                });

            modelBuilder.Entity("Mission06_masfrod2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Sci-Fi/Adventure"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Thriller"
                        });
                });

            modelBuilder.Entity("Mission06_masfrod2.Models.AddMovieResponse", b =>
                {
                    b.HasOne("Mission06_masfrod2.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}