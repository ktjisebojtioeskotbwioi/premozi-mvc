﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using premozi.Models;

#nullable disable

namespace premozi.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20250304072056_add-migration 103pccopy")]
    partial class addmigration103pccopy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("premozi.Models.Felhasznalok", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("userID"));

                    b.Property<int>("account_status")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(1)
                        .HasColumnType("int(1)");

                    b.Property<DateTime>("creation_date")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DateTime");

                    MySqlPropertyBuilderExtensions.UseMySqlComputedColumn(b.Property<DateTime>("creation_date"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("char(88)");

                    b.Property<int>("priviledges")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(1)
                        .HasColumnType("int(1)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("userID");

                    b.ToTable("Felhasznalok");
                });
#pragma warning restore 612, 618
        }
    }
}
