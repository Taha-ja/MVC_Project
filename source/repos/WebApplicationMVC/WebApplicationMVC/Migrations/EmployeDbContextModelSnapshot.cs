﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationMVC.Models.Data;

#nullable disable

namespace WebApplicationMVC.Migrations
{
    [DbContext(typeof(EmployeDbContext))]
    partial class EmployeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplicationMVC.Models.Employe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Departement")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employes");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Age = 25,
                            Departement = 0,
                            Email = "employe1@gmail.com",
                            Image = "/Images/e1.jpg",
                            Name = "Employe1"
                        },
                        new
                        {
                            Id = 3,
                            Age = 30,
                            Departement = 2,
                            Email = "employe2@gmail.com",
                            Image = "/Images/e2.png",
                            Name = "Employe2"
                        },
                        new
                        {
                            Id = 4,
                            Age = 32,
                            Departement = 1,
                            Email = "employe3@gmail.com",
                            Image = "/Images/e3.png",
                            Name = "Employe3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
