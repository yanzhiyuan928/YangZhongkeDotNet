﻿// <auto-generated />
using System;
using ConsoleAppEFCoreCongestiveModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleAppEFCoreCongestiveModel.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsoleAppEFCoreCongestiveModel.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("ConsoleAppEFCoreCongestiveModel.EntityCurrency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EntityCurrencies");
                });

            modelBuilder.Entity("ConsoleAppEFCoreCongestiveModel.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("ConsoleAppEFCoreCongestiveModel.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwordHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConsoleAppEFCoreCongestiveModel.Blog", b =>
                {
                    b.OwnsOne("ConsoleAppEFCoreCongestiveModel.MultilingualString", "Body", b1 =>
                        {
                            b1.Property<int>("BlogId")
                                .HasColumnType("int");

                            b1.Property<string>("Chinese")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("English")
                                .HasColumnType("varchar(MAX)");

                            b1.HasKey("BlogId");

                            b1.ToTable("Blogs");

                            b1.WithOwner()
                                .HasForeignKey("BlogId");
                        });

                    b.OwnsOne("ConsoleAppEFCoreCongestiveModel.MultilingualString", "Title", b1 =>
                        {
                            b1.Property<int>("BlogId")
                                .HasColumnType("int");

                            b1.Property<string>("Chinese")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("English")
                                .HasColumnType("varchar(255)");

                            b1.HasKey("BlogId");

                            b1.ToTable("Blogs");

                            b1.WithOwner()
                                .HasForeignKey("BlogId");
                        });

                    b.Navigation("Body")
                        .IsRequired();

                    b.Navigation("Title")
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleAppEFCoreCongestiveModel.Shop", b =>
                {
                    b.OwnsOne("ConsoleAppEFCoreCongestiveModel.Geo", "Location", b1 =>
                        {
                            b1.Property<int>("ShopId")
                                .HasColumnType("int");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("ShopId");

                            b1.ToTable("Shops");

                            b1.WithOwner()
                                .HasForeignKey("ShopId");
                        });

                    b.Navigation("Location")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
