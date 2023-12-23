﻿// <auto-generated />
using FernwehApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FernwehApi.Migrations
{
    [DbContext(typeof(PlacesDbContext))]
    [Migration("20231223150344_AddedPlacesDbContext")]
    partial class AddedPlacesDbContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FernwehApi.Models.DisplayName", b =>
                {
                    b.Property<string>("DisplayNameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisplayNameId");

                    b.ToTable("DisplayName");
                });

            modelBuilder.Entity("FernwehApi.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaceId"));

                    b.Property<string>("DisplayNameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FormattedAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("UserRatingCount")
                        .HasColumnType("int");

                    b.HasKey("PlaceId");

                    b.HasIndex("DisplayNameId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("FernwehApi.Models.Place", b =>
                {
                    b.HasOne("FernwehApi.Models.DisplayName", "DisplayName")
                        .WithMany()
                        .HasForeignKey("DisplayNameId");

                    b.Navigation("DisplayName");
                });
#pragma warning restore 612, 618
        }
    }
}
