﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task2.Infrastructure.Database;

#nullable disable

namespace Task2.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240219195803_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Task2.Core.People.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"),
                            Family = "Parker",
                            Name = "Jane",
                            Version = new Guid("d5b2bdd8-5d5b-473f-a81d-cf645512a77c")
                        },
                        new
                        {
                            Id = new Guid("d745193c-8a95-4828-918c-88390f2e212e"),
                            Family = "Copper",
                            Name = "Mike",
                            Version = new Guid("5e85b02b-7724-4fd5-86ff-7c73af5adeac")
                        });
                });

            modelBuilder.Entity("Task2.Core.Transactions.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("41f5bab3-6dcd-425c-bf4d-dbd1485d8a31"),
                            PersonId = new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"),
                            Price = 100000,
                            TransactionDate = new DateTime(2019, 11, 1, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            Version = new Guid("b680af96-cb47-4df8-9bbe-c3a84395868c")
                        },
                        new
                        {
                            Id = new Guid("6f58926d-7332-4446-b644-254d894438ce"),
                            PersonId = new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"),
                            Price = 200000,
                            TransactionDate = new DateTime(2019, 11, 1, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            Version = new Guid("3f16fd22-3850-47f8-9d3d-b3cdb9664cc8")
                        },
                        new
                        {
                            Id = new Guid("65a2d24f-f466-4cc4-b4e7-a5559fcd90a8"),
                            PersonId = new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"),
                            Price = 50000,
                            TransactionDate = new DateTime(2019, 11, 1, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            Version = new Guid("8018ae45-840f-43b2-b626-7a9ce0c72a72")
                        },
                        new
                        {
                            Id = new Guid("4e6c1cbd-6b69-47ad-81b5-6ff0e31a8150"),
                            PersonId = new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"),
                            Price = 300000,
                            TransactionDate = new DateTime(2019, 11, 3, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            Version = new Guid("a745adf2-8be5-49a0-8bfe-8a1a2fb0e69b")
                        },
                        new
                        {
                            Id = new Guid("7c2856e1-efe4-4a71-8754-4c1cf0719675"),
                            PersonId = new Guid("d745193c-8a95-4828-918c-88390f2e212e"),
                            Price = 100000,
                            TransactionDate = new DateTime(2019, 11, 1, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Version = new Guid("3781ccde-44ae-4e6b-b32b-951561b4ef12")
                        },
                        new
                        {
                            Id = new Guid("d4810df7-2d29-466e-a329-6eb045cc05ca"),
                            PersonId = new Guid("d745193c-8a95-4828-918c-88390f2e212e"),
                            Price = 20000,
                            TransactionDate = new DateTime(2019, 11, 1, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            Version = new Guid("cf266ca7-adb8-44ea-ab5b-aaabd43e1705")
                        });
                });

            modelBuilder.Entity("Task2.Core.Transactions.Transaction", b =>
                {
                    b.HasOne("Task2.Core.People.Person", "Person")
                        .WithMany("Transactions")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Task2.Core.People.Person", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
