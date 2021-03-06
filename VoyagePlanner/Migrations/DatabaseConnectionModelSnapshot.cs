﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoyagePlanner;

namespace VoyagePlanner.Migrations
{
    [DbContext(typeof(DatabaseConnection))]
    partial class DatabaseConnectionModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VoyagePlanner.Address", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<long>("PostalCode");

                    b.HasKey("ID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("VoyagePlanner.Company", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AddressID");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<long>("PostalCode");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("VoyagePlanner.Location", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Country");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("LocationCode");

                    b.Property<string>("LocationName");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<long>("PostalCode");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("VoyagePlanner.Path", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.HasKey("ID");

                    b.ToTable("Path");
                });

            modelBuilder.Entity("VoyagePlanner.PathLocation", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("LocationId");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<long>("PathId");

                    b.Property<long>("SortNo");

                    b.HasKey("ID");

                    b.ToTable("PathLocation");
                });

            modelBuilder.Entity("VoyagePlanner.VoyagePlan", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<long?>("LocationID");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.ToTable("VoyagePlan");
                });

            modelBuilder.Entity("VoyagePlanner.VoyagePlanDetail", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<long>("Location");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.HasKey("ID");

                    b.ToTable("VoyagePlanDetail");
                });

            modelBuilder.Entity("VoyagePlanner.VoyagePlanTemplate", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<long>("Path");

                    b.HasKey("ID");

                    b.ToTable("VoyagePlanTemplate");
                });

            modelBuilder.Entity("VoyagePlanner.VoyagePlanTemplateDetail", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ArrivalTime");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DayOfWeek");

                    b.Property<int>("DayofWeekArrival");

                    b.Property<int>("DayofWeekDeparture");

                    b.Property<string>("DepartureTime");

                    b.Property<long?>("LocationID");

                    b.Property<long>("ModifiedBy");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<long>("VoyagePlanNumber");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.ToTable("VoyagePlanTemplateDetails");
                });

            modelBuilder.Entity("VoyagePlanner.Company", b =>
                {
                    b.HasOne("VoyagePlanner.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");
                });

            modelBuilder.Entity("VoyagePlanner.VoyagePlan", b =>
                {
                    b.HasOne("VoyagePlanner.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");
                });

            modelBuilder.Entity("VoyagePlanner.VoyagePlanTemplateDetail", b =>
                {
                    b.HasOne("VoyagePlanner.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");
                });
#pragma warning restore 612, 618
        }
    }
}
