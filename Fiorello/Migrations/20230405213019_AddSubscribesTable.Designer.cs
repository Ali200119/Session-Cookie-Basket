﻿// <auto-generated />
using Fiorello.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiorello.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230405213019_AddSubscribesTable")]
    partial class AddSubscribesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fiorello.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoCover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion...",
                            SoftDelete = false,
                            Title = "<h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>",
                            VideoCover = "h3-video-img.jpg"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Advantage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Advantages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AboutId = 1,
                            Description = "Hand picked just for you.",
                            Icon = "h1-custom-icon.png",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            AboutId = 1,
                            Description = "Unique flower arrangements.",
                            Icon = "h1-custom-icon.png",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            AboutId = 1,
                            Description = "Best way to say you care.",
                            Icon = "h1-custom-icon.png",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a smile for you.",
                            SoftDelete = false,
                            Title = "Flower Experts"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExpertId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ExpertId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpertId = 1,
                            Image = "h3-team-img-1.png",
                            Name = "CRYSTAL BROOKS",
                            Position = "Florist",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            ExpertId = 1,
                            Image = "h3-team-img-2.png",
                            Name = "SHIRLEY HARRIS",
                            Position = "Manager",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            ExpertId = 1,
                            Image = "h3-team-img-3.png",
                            Name = "BEVERLY CLARK",
                            Position = "Florist",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            ExpertId = 1,
                            Image = "h3-team-img-4.png",
                            Name = "AMANDA WATKINS",
                            Position = "Florist",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h3-slider-background.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Image = "h3-slider-background-2.jpg",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            Image = "h3-slider-background-3.jpg",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Fiorello.Models.SliderInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignatureImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SliderInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.",
                            SignatureImage = "h2-sign-img.png",
                            SoftDelete = false,
                            Title = "<h1>Send <span>flowers</span> like</h1><h1>you mean it</h1>"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Subscribe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BackgroundImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscribes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackgroundImage = "h3-background-img.jpg",
                            SoftDelete = false,
                            Title = "Join The Colorful Bunch!"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Advantage", b =>
                {
                    b.HasOne("Fiorello.Models.About", "About")
                        .WithMany("Advantages")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");
                });

            modelBuilder.Entity("Fiorello.Models.Person", b =>
                {
                    b.HasOne("Fiorello.Models.Expert", "Expert")
                        .WithMany("Persons")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");
                });

            modelBuilder.Entity("Fiorello.Models.About", b =>
                {
                    b.Navigation("Advantages");
                });

            modelBuilder.Entity("Fiorello.Models.Expert", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
