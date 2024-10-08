﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PresOrm.Data;

#nullable disable

namespace PresOrm.Data.Migrations
{
    [DbContext(typeof(ContextPresOrm))]
    partial class ContextPresOrmModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PresOrm.Data.Entities.EntityBrand", b =>
                {
                    b.Property<long>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("BrandId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("BrandId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .IsDescending();

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("PresOrm.Data.Entities.EntityCar", b =>
                {
                    b.Property<long>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CarId"));

                    b.Property<long>("BrandId")
                        .HasColumnType("bigint");

                    b.Property<DateOnly>("ModelYear")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("CarId");

                    b.HasIndex("BrandId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .IsDescending();

                    b.ToTable("Car");
                });

            modelBuilder.Entity("PresOrm.Data.Entities.EntityCar", b =>
                {
                    b.HasOne("PresOrm.Data.Entities.EntityBrand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });
#pragma warning restore 612, 618
        }
    }
}
