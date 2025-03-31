﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication5.Data;

#nullable disable

namespace WebApplication5.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication5.Model.CelestialObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Age")
                        .HasColumnType("float");

                    b.Property<string>("AlternateDesignation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Characteristics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Composition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Constellation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Declination")
                        .HasColumnType("float");

                    b.Property<string>("DiscoveredBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DiscoveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscoveryMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DistanceFromEarth")
                        .HasColumnType("float");

                    b.Property<int?>("ExoplanetCount")
                        .HasColumnType("int");

                    b.Property<bool>("HasExoplanets")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestingFacts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInteresting")
                        .HasColumnType("bit");

                    b.Property<double>("Magnitude")
                        .HasColumnType("float");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("OrbitalEccentricity")
                        .HasColumnType("float");

                    b.Property<double?>("OrbitalPeriod")
                        .HasColumnType("float");

                    b.Property<string>("OrbitingBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Radius")
                        .HasColumnType("float");

                    b.Property<string>("ResearchHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RightAscension")
                        .HasColumnType("float");

                    b.Property<double?>("RotationPeriod")
                        .HasColumnType("float");

                    b.Property<string>("SpectralType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Temperature")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CelestialObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
