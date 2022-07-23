﻿// <auto-generated />
using System;
using CapacityPlanApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapacityPlanApp.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("CapacityPlanApp.Models.CapacityPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CapView")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("cap_view");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint(0)")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("status");

                    b.Property<string>("WeekStart")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("week_start");

                    b.Property<int?>("cp_details_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cp_details_id");

                    b.ToTable("capacity_plan");
                });

            modelBuilder.Entity("CapacityPlanApp.Models.CapacityPlanDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("DateFrom")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("date_from");

                    b.Property<string>("DateTo")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("date_to");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint(0)")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("capacity_plan_details");
                });

            modelBuilder.Entity("CapacityPlanApp.Models.CapacityPlan", b =>
                {
                    b.HasOne("CapacityPlanApp.Models.CapacityPlanDetails", "CapacityPlanDetails")
                        .WithMany()
                        .HasForeignKey("cp_details_id");

                    b.Navigation("CapacityPlanDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
