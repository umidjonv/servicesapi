﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using productsapi.Data;

namespace productsapi.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20200813203102_ImageMigration")]
    partial class ImageMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("productsapi.Entities.Image", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("path")
                        .HasColumnType("text");

                    b.Property<Guid?>("productid")
                        .HasColumnType("uuid");

                    b.Property<bool>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("productsapi.Entities.Log.EntityLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<string>("table")
                        .HasColumnType("text");

                    b.Property<DateTime>("updated_at")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("id");

                    b.ToTable("Entity");
                });

            modelBuilder.Entity("productsapi.Models.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("parentid")
                        .HasColumnType("uuid");

                    b.Property<bool>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.HasKey("id");

                    b.HasIndex("parentid");

                    b.ToTable("category");
                });

            modelBuilder.Entity("productsapi.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("categoryid")
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<float>("sale_price")
                        .HasColumnType("real");

                    b.Property<bool>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.HasKey("id");

                    b.HasIndex("categoryid");

                    b.ToTable("product");
                });

            modelBuilder.Entity("productsapi.Entities.Image", b =>
                {
                    b.HasOne("productsapi.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");
                });

            modelBuilder.Entity("productsapi.Models.Category", b =>
                {
                    b.HasOne("productsapi.Models.Category", "parent")
                        .WithMany("childs")
                        .HasForeignKey("parentid");
                });

            modelBuilder.Entity("productsapi.Models.Product", b =>
                {
                    b.HasOne("productsapi.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
