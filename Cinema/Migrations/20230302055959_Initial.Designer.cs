﻿// <auto-generated />
using System;
using CinemaApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace CinemaApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230302055959_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CinemaApp.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("CinemaApp.Entities.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Point>("Ubication")
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CinemaApp.Entities.CinemaOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<decimal>("DiscountRate")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId")
                        .IsUnique();

                    b.ToTable("CinemaOffer");
                });

            modelBuilder.Entity("CinemaApp.Entities.CinemaRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("CinemaRoomType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("CinemasRooms");
                });

            modelBuilder.Entity("CinemaApp.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("InBillboard")
                        .HasColumnType("bit");

                    b.Property<string>("PosterURL")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("CinemaApp.Entities.FilmActor", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("FilmsActors");
                });

            modelBuilder.Entity("CinemaApp.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("CinemaRoomFilm", b =>
                {
                    b.Property<int>("CinemaRoomsId")
                        .HasColumnType("int");

                    b.Property<int>("filmsId")
                        .HasColumnType("int");

                    b.HasKey("CinemaRoomsId", "filmsId");

                    b.HasIndex("filmsId");

                    b.ToTable("CinemaRoomFilm");
                });

            modelBuilder.Entity("FilmGenre", b =>
                {
                    b.Property<int>("FilmsId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("FilmsId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("FilmGenre");
                });

            modelBuilder.Entity("CinemaApp.Entities.CinemaOffer", b =>
                {
                    b.HasOne("CinemaApp.Entities.Cinema", null)
                        .WithOne("CinemaOffer")
                        .HasForeignKey("CinemaApp.Entities.CinemaOffer", "CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaApp.Entities.CinemaRoom", b =>
                {
                    b.HasOne("CinemaApp.Entities.Cinema", "Cinema")
                        .WithMany("CinemaRooms")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("CinemaApp.Entities.FilmActor", b =>
                {
                    b.HasOne("CinemaApp.Entities.Actor", "Actor")
                        .WithMany("FilmActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaApp.Entities.Film", "Film")
                        .WithMany("FilmActors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("CinemaRoomFilm", b =>
                {
                    b.HasOne("CinemaApp.Entities.CinemaRoom", null)
                        .WithMany()
                        .HasForeignKey("CinemaRoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaApp.Entities.Film", null)
                        .WithMany()
                        .HasForeignKey("filmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmGenre", b =>
                {
                    b.HasOne("CinemaApp.Entities.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaApp.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaApp.Entities.Actor", b =>
                {
                    b.Navigation("FilmActors");
                });

            modelBuilder.Entity("CinemaApp.Entities.Cinema", b =>
                {
                    b.Navigation("CinemaOffer");

                    b.Navigation("CinemaRooms");
                });

            modelBuilder.Entity("CinemaApp.Entities.Film", b =>
                {
                    b.Navigation("FilmActors");
                });
#pragma warning restore 612, 618
        }
    }
}