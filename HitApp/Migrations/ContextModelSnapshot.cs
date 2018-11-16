﻿// <auto-generated />
using System;
using HitApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HitApp.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HitApp.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectContractorInfo");

                    b.Property<string>("ProjectDescription");

                    b.Property<DateTime>("ProjectEndDate");

                    b.Property<string>("ProjectName");

                    b.Property<DateTime>("ProjectStartDate");

                    b.Property<double>("ProjectTotalBudget");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new { ProjectId = 1, ProjectContractorInfo = "Jimmy the Tile Guy", ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectEndDate = new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectName = "Bathroom", ProjectStartDate = new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 10000.0 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
