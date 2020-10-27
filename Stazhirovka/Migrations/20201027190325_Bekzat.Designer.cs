﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Stazhirovka.Data;

namespace Stazhirovka.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201027190325_Bekzat")]
    partial class Bekzat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Stazhirovka.Models.GenreReference", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("genreName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("References");
                });

            modelBuilder.Entity("Stazhirovka.Models.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("endDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("genreid")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<bool>("relevance")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.HasIndex("genreid");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Stazhirovka.Models.Movie", b =>
                {
                    b.HasOne("Stazhirovka.Models.GenreReference", "genre")
                        .WithMany()
                        .HasForeignKey("genreid");
                });
#pragma warning restore 612, 618
        }
    }
}
