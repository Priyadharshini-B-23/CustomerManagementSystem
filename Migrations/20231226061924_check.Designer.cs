﻿// <auto-generated />
using Customer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TrainerManagement.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20231226061924_check")]
    partial class check
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Customer.Data.Customer", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Customer_Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Customer_PhNum")
                        .HasColumnType("bigint");

                    b.HasKey("Customer_Id");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
