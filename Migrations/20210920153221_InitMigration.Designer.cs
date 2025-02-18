﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ApiAspnetCore.Data;

namespace ApiAspnetCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210920153221_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("api_aspnet_core.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("api_aspnet_core.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("categoriesid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoriesid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("api_aspnet_core.Models.Product", b =>
                {
                    b.HasOne("api_aspnet_core.Models.Category", "categories")
                        .WithMany("products")
                        .HasForeignKey("categoriesid");

                    b.Navigation("categories");
                });

            modelBuilder.Entity("api_aspnet_core.Models.Category", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
