﻿// <auto-generated />
using System;
using BackEnd.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEnd.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackEnd.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("ENDS")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LOG_DATE_CREATE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LOG_DATE_UPDATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("LOG_USER_CREATE")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LOG_USER_UPDATE")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("USER_NAME")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("USER_PASSWORD")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
