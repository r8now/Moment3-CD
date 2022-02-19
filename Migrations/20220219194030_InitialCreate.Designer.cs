﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moment3_CD.Data;

#nullable disable

namespace Moment3_CD.Migrations
{
    [DbContext(typeof(CdContext))]
    [Migration("20220219194030_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Moment3_CD.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Moment3_CD.Models.Cd", b =>
                {
                    b.Property<int>("CdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("CdId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Cd");
                });

            modelBuilder.Entity("Moment3_CD.Models.Cd", b =>
                {
                    b.HasOne("Moment3_CD.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}
