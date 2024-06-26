﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zenzero.Core.Persistence;

#nullable disable

namespace Zenzero.Web.Migrations
{
    [DbContext(typeof(ZenzeroContext))]
    [Migration("20240626113149_IntialCreate")]
    partial class IntialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Zenzero.Core.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDateInitial")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("OrderDateLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Zenzero.Core.Models.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("Zenzero.Core.Models.OrderLine", b =>
                {
                    b.HasOne("Zenzero.Core.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Zenzero.Core.Models.Order", b =>
                {
                    b.Navigation("OrderLines");
                });
#pragma warning restore 612, 618
        }
    }
}
