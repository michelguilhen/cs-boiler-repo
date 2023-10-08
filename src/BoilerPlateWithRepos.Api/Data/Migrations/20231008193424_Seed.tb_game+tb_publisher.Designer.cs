﻿// <auto-generated />
using System;
using BoilerPlateWithRepos.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoilerPlateWithRepos.Api.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231008193424_Seed.tb_game+tb_publisher")]
    partial class Seedtb_gametb_publisher
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BoilerPlateWithRepos.Api.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<Guid>("publisher_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("publisher_id");

                    b.ToTable("tb_game", (string)null);
                });

            modelBuilder.Entity("BoilerPlateWithRepos.Api.Models.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("tb_publisher", (string)null);
                });

            modelBuilder.Entity("BoilerPlateWithRepos.Api.Models.Game", b =>
                {
                    b.HasOne("BoilerPlateWithRepos.Api.Models.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("publisher_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BoilerPlateWithRepos.Api.Models.Publisher", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}