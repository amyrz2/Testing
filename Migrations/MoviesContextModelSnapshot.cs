﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

namespace Movies.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Movies.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            CategoryID = 14,
                            Director = "Lulu Wang",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "The Farewell",
                            Year = 2019
                        },
                        new
                        {
                            ApplicationID = 2,
                            CategoryID = 9,
                            Director = "Jon Turteltaub",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "While You Were Sleeping",
                            Year = 1995
                        },
                        new
                        {
                            ApplicationID = 3,
                            CategoryID = 3,
                            Director = "Gus Van Sant",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "R",
                            Title = "Good Will Hunting",
                            Year = 1997
                        });
                });

            modelBuilder.Entity("Movies.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comdey"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "VHS"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Musicals"
                        },
                        new
                        {
                            CategoryID = 11,
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryID = 12,
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryID = 13,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 14,
                            CategoryName = "Comdey/Drama"
                        });
                });

            modelBuilder.Entity("Movies.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Movies.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
