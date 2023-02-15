﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTickets.Data;

#nullable disable

namespace eTickets.Migrations
{
    [DbContext(typeof(ConcertContext))]
    [Migration("20230215014404_2")]
    partial class _2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eTickets.Data.ConcertCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("ConcertCategory");
                });

            modelBuilder.Entity("eTickets.Models.BandModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bands");
                });

            modelBuilder.Entity("eTickets.Models.ConcertModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<int>("ConcertCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.HasIndex("ConcertCategoryId");

                    b.HasIndex("VenueId");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("eTickets.Models.Concert_Bands", b =>
                {
                    b.Property<int>("BandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BandId"));

                    b.Property<int>("BandId1")
                        .HasColumnType("int");

                    b.Property<int>("ConcertID")
                        .HasColumnType("int");

                    b.HasKey("BandId");

                    b.HasIndex("BandId1");

                    b.ToTable("Concert_Bands");
                });

            modelBuilder.Entity("eTickets.Models.MusicianModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BandModelId")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BandModelId");

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("eTickets.Models.Musician_Band", b =>
                {
                    b.Property<int>("MusicianId")
                        .HasColumnType("int");

                    b.Property<int>("BandId")
                        .HasColumnType("int");

                    b.Property<int?>("ConcertModelId")
                        .HasColumnType("int");

                    b.HasKey("MusicianId", "BandId");

                    b.HasIndex("BandId");

                    b.HasIndex("ConcertModelId");

                    b.ToTable("Musician_Band");
                });

            modelBuilder.Entity("eTickets.Models.VenueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("eTickets.Models.ConcertModel", b =>
                {
                    b.HasOne("eTickets.Models.BandModel", "Band")
                        .WithMany()
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTickets.Data.ConcertCategory", "ConcertCategory")
                        .WithMany()
                        .HasForeignKey("ConcertCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTickets.Models.VenueModel", "Venue")
                        .WithMany("Concerts")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("ConcertCategory");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("eTickets.Models.Concert_Bands", b =>
                {
                    b.HasOne("eTickets.Models.BandModel", "Band")
                        .WithMany()
                        .HasForeignKey("BandId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");
                });

            modelBuilder.Entity("eTickets.Models.MusicianModel", b =>
                {
                    b.HasOne("eTickets.Models.BandModel", null)
                        .WithMany("Bands")
                        .HasForeignKey("BandModelId");
                });

            modelBuilder.Entity("eTickets.Models.Musician_Band", b =>
                {
                    b.HasOne("eTickets.Models.BandModel", "Band")
                        .WithMany("Musicians_Bands")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTickets.Models.ConcertModel", null)
                        .WithMany("Musician_Band")
                        .HasForeignKey("ConcertModelId");

                    b.HasOne("eTickets.Models.MusicianModel", "Musician")
                        .WithMany("Musicians_Bands")
                        .HasForeignKey("MusicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Band");

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("eTickets.Models.BandModel", b =>
                {
                    b.Navigation("Bands");

                    b.Navigation("Musicians_Bands");
                });

            modelBuilder.Entity("eTickets.Models.ConcertModel", b =>
                {
                    b.Navigation("Musician_Band");
                });

            modelBuilder.Entity("eTickets.Models.MusicianModel", b =>
                {
                    b.Navigation("Musicians_Bands");
                });

            modelBuilder.Entity("eTickets.Models.VenueModel", b =>
                {
                    b.Navigation("Concerts");
                });
#pragma warning restore 612, 618
        }
    }
}
