﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using exercise.wwwapi.Data;

#nullable disable

namespace exercise.wwwapi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("exercise.wwwapi.DataModels.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("AvgGrade")
                        .HasColumnType("double precision")
                        .HasColumnName("grade");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvgGrade = 1.5,
                            StartDate = new DateOnly(2024, 8, 8),
                            Title = "Java"
                        },
                        new
                        {
                            Id = 2,
                            AvgGrade = 5.2000000000000002,
                            StartDate = new DateOnly(2024, 8, 8),
                            Title = ".NET"
                        });
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Birth")
                        .HasColumnType("date")
                        .HasColumnName("birth");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("firstname");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("lastname");

                    b.HasKey("Id");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birth = new DateOnly(2000, 7, 20),
                            CourseId = 2,
                            FirstName = "Espen",
                            LastName = "Luna"
                        },
                        new
                        {
                            Id = 2,
                            Birth = new DateOnly(2000, 6, 26),
                            CourseId = 2,
                            FirstName = "Eyvind",
                            LastName = "Malde"
                        },
                        new
                        {
                            Id = 3,
                            Birth = new DateOnly(2000, 10, 8),
                            CourseId = 1,
                            FirstName = "Daniel",
                            LastName = "Røli"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
