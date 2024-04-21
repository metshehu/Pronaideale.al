﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.Agends", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanysId")
                        .HasColumnType("int");

                    b.Property<int>("Deals")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YoE")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CompanysId");

                    b.ToTable("Agends");
                });

            modelBuilder.Entity("api.Models.Companys", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("api.Models.Propertys", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("AgendId")
                        .HasColumnType("int");

                    b.Property<int?>("Agendsid")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Enrange")
                        .HasColumnType("decimal(18,2 )");

                    b.Property<decimal>("Monthly")
                        .HasColumnType("decimal(18,2 )");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("STrange")
                        .HasColumnType("decimal(18,2 )");

                    b.Property<decimal>("Size")
                        .HasColumnType("decimal(30,5 )");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Agendsid");

                    b.HasIndex("UsersId");

                    b.ToTable("Propertys");
                });

            modelBuilder.Entity("api.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Agendsid")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Agendsid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.Models.Agends", b =>
                {
                    b.HasOne("api.Models.Companys", "Companys")
                        .WithMany("Agends")
                        .HasForeignKey("CompanysId");

                    b.Navigation("Companys");
                });

            modelBuilder.Entity("api.Models.Propertys", b =>
                {
                    b.HasOne("api.Models.Agends", "Agends")
                        .WithMany("Propertys")
                        .HasForeignKey("Agendsid");

                    b.HasOne("api.Models.Users", "Users")
                        .WithMany("Propertys")
                        .HasForeignKey("UsersId");

                    b.Navigation("Agends");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("api.Models.Users", b =>
                {
                    b.HasOne("api.Models.Agends", null)
                        .WithMany("Users")
                        .HasForeignKey("Agendsid");
                });

            modelBuilder.Entity("api.Models.Agends", b =>
                {
                    b.Navigation("Propertys");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("api.Models.Companys", b =>
                {
                    b.Navigation("Agends");
                });

            modelBuilder.Entity("api.Models.Users", b =>
                {
                    b.Navigation("Propertys");
                });
#pragma warning restore 612, 618
        }
    }
}
