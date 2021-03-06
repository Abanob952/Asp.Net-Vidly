﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vidly.Models;

namespace Vidly.Migrations
{
    [DbContext(typeof(DBModel))]
    [Migration("20210119172650_fillnamemember")]
    partial class fillnamemember
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsSubscribedToNewsLetter")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("memberShipTypesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("memberShipTypesId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Vidly.Models.MemberShipTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DurationInMonth")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MemberShipTypes");
                });

            modelBuilder.Entity("Vidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Vidly.Models.Customer", b =>
                {
                    b.HasOne("Vidly.Models.MemberShipTypes", "memberShipType")
                        .WithMany()
                        .HasForeignKey("memberShipTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("memberShipType");
                });
#pragma warning restore 612, 618
        }
    }
}