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
    [Migration("20250307091736_huh")]
    partial class huh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("premozi.Models.Film", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("AlapAr")
                        .HasColumnType("INT(11)");

                    b.Property<string>("Cim")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Eredeti_cim")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Eredeti_nyelv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gyarto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IMDB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Jatekido")
                        .HasColumnType("INT(4)");

                    b.Property<string>("Kategoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Korhatar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Leiras")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Megjegyzes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mufaj")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rendezo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Szereplok")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Szinkron")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("premozi.Models.Rendeles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Hely")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Megjegyzes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Statusz")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int(1)");

                    b.Property<int>("Vetitesid")
                        .HasColumnType("int(5)");

                    b.Property<int>("userID")
                        .HasColumnType("int(11)");

                    b.HasKey("id");

                    b.HasIndex("Vetitesid");

                    b.HasIndex("userID");

                    b.ToTable("Rendeles");
                });

            modelBuilder.Entity("premozi.Models.Terem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(5)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Allapot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Ferohely")
                        .HasColumnType("int(3)");

                    b.Property<string>("Megjegyzes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sorok")
                        .HasColumnType("int(3)");

                    b.Property<string>("Tipus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Terem");
                });

            modelBuilder.Entity("premozi.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("userID"));

                    b.Property<string>("Megjegyzes")
                        .IsRequired()
                        .HasColumnType("longtext");

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

                    b.HasIndex("email")
                        .IsUnique();

                    b.HasIndex("username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("premozi.Models.Vetites", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(5)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Filmid")
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("Idopont")
                        .HasColumnType("DateTime");

                    b.Property<string>("Megjegyzes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Teremid")
                        .HasColumnType("int(5)");

                    b.HasKey("id");

                    b.HasIndex("Filmid");

                    b.HasIndex("Teremid");

                    b.ToTable("Vetites");
                });

            modelBuilder.Entity("premozi.Models.Rendeles", b =>
                {
                    b.HasOne("premozi.Models.Vetites", "Vetites")
                        .WithMany()
                        .HasForeignKey("Vetitesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("premozi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vetites");
                });

            modelBuilder.Entity("premozi.Models.Vetites", b =>
                {
                    b.HasOne("premozi.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("Filmid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("premozi.Models.Terem", "Terem")
                        .WithMany()
                        .HasForeignKey("Teremid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Terem");
                });
#pragma warning restore 612, 618
        }
    }
}
