﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services.Order.Data;

namespace ShoppingMallDemo.Data.Migrations.Order
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20181002210159_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Services.Order.Models.Entity.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("DeliveryMethod");

                    b.Property<int>("OrderStatus");

                    b.Property<decimal?>("TotalPrice")
                        .IsRequired()
                        .HasColumnType("DECIMAL(8,2)");

                    b.Property<long?>("UserID")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Services.Order.Models.Entity.OrderItem", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("OrderID")
                        .IsRequired();

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("DECIMAL(8,2)");

                    b.Property<long?>("ProductID")
                        .IsRequired();

                    b.Property<int?>("Quantity")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Services.Order.Models.Entity.OrderItem", b =>
                {
                    b.HasOne("Services.Order.Models.Entity.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
