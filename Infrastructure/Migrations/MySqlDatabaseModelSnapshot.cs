﻿// <auto-generated />
using System;
using Infrastructure.Database.MySQLDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MySqlDatabase))]
    partial class MySqlDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Animal.AnimalModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AnimalModel");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnimalModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.UserAnimal", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "AnimalId");

                    b.HasIndex("AnimalId");

                    b.ToTable("UserAnimal");
                });

            modelBuilder.Entity("Domain.Models.Bird", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<bool>("CanFly")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Bird");

                    b.HasData(
                        new
                        {
                            Id = new Guid("16da9dd8-74d7-4adb-902b-af90b600e21b"),
                            Name = "Parrot",
                            CanFly = false,
                            Color = ""
                        },
                        new
                        {
                            Id = new Guid("bdeb14ea-931b-414a-87bf-0ee3e3dd1043"),
                            Name = "Cortex",
                            CanFly = false,
                            Color = ""
                        },
                        new
                        {
                            Id = new Guid("19afbabc-edaa-43b4-a7be-747f6e04737e"),
                            Name = "Fench",
                            CanFly = false,
                            Color = ""
                        },
                        new
                        {
                            Id = new Guid("e7f75502-6a39-4601-934f-845f7e66476d"),
                            Name = "Feri",
                            CanFly = false,
                            Color = ""
                        });
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cat");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f058daee-ae98-496b-82d1-6f210d9de46a"),
                            Name = "Nuno",
                            Breed = "",
                            LikesToPlay = false,
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("b11d75b4-c99d-4d79-a4b2-7ee9b442c303"),
                            Name = "Mani",
                            Breed = "",
                            LikesToPlay = false,
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("d8877a26-127b-444e-a061-aa310c2fe5fe"),
                            Name = "Puppy",
                            Breed = "",
                            LikesToPlay = false,
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("60981a15-c85c-4c29-bd56-32c9e172d7ed"),
                            Name = "Shima",
                            Breed = "",
                            LikesToPlay = false,
                            Weight = 0
                        });
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.ToTable("AnimalModel", t =>
                        {
                            t.Property("Breed")
                                .HasColumnName("Dog_Breed");

                            t.Property("Weight")
                                .HasColumnName("Dog_Weight");
                        });

                    b.HasDiscriminator().HasValue("Dog");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e54162dd-07d9-4ab3-a400-181bdddcfba3"),
                            Name = "",
                            Breed = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("f1049b4f-69a4-4186-9c81-585e75300640"),
                            Name = "",
                            Breed = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("a30b481d-2835-4f6d-9116-600086e32e15"),
                            Name = "",
                            Breed = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("3cb0e74b-89eb-46a6-8bf4-dcc2b4852af3"),
                            Name = "",
                            Breed = "",
                            Weight = 0
                        });
                });

            modelBuilder.Entity("Domain.Models.UserAnimal", b =>
                {
                    b.HasOne("Domain.Models.Animal.AnimalModel", "Animal")
                        .WithMany("UserAnimals")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("UserAnimals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Animal.AnimalModel", b =>
                {
                    b.Navigation("UserAnimals");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("UserAnimals");
                });
#pragma warning restore 612, 618
        }
    }
}
