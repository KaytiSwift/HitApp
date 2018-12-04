﻿// <auto-generated />
using System;
using HitApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HitApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HitApp.Models.Contractor", b =>
                {
                    b.Property<int>("ContractorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractorAdditionalNotes");

                    b.Property<string>("ContractorAddress");

                    b.Property<string>("ContractorCity");

                    b.Property<string>("ContractorCompany");

                    b.Property<string>("ContractorEmail");

                    b.Property<string>("ContractorName")
                        .IsRequired();

                    b.Property<string>("ContractorPhone");

                    b.Property<string>("ContractorService");

                    b.Property<string>("ContractorState");

                    b.Property<string>("ContractorWebsiteUrl");

                    b.Property<int?>("ContractorZip");

                    b.HasKey("ContractorId");

                    b.ToTable("Contractors");

                    b.HasData(
                        new { ContractorId = 1, ContractorAdditionalNotes = "Jimmy the tile guy", ContractorCity = "Madison", ContractorCompany = "Self", ContractorEmail = "tectile@live.com", ContractorName = "Jimmy McDermitt", ContractorState = "Ohio" }
                    );
                });

            modelBuilder.Entity("HitApp.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ExpenseCost");

                    b.Property<DateTime>("ExpenseDatePurchased");

                    b.Property<string>("ExpenseName")
                        .IsRequired();

                    b.Property<string>("ExpenseNotes");

                    b.Property<string>("ProductUrl");

                    b.Property<int>("ProjectId");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new { ExpenseId = 1, ExpenseCost = 420.0, ExpenseDatePurchased = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "TestExpense1", ExpenseNotes = "This is a test", ProductUrl = "https://www.homedepot.com/p/Warehouse-of-Tiffany-Stella-12-in-Bronze-Accent-Desk-Lamp-with-Red-Dragonfly-Shade-305RBTL/206800480", ProjectId = 1 }
                    );
                });

            modelBuilder.Entity("HitApp.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription");

                    b.Property<DateTime?>("ProjectEndDate");

                    b.Property<bool>("ProjectIsOnDashboard");

                    b.Property<string>("ProjectName");

                    b.Property<string>("ProjectOwnerId");

                    b.Property<DateTime>("ProjectStartDate");

                    b.Property<double>("ProjectTotalBudget");

                    b.Property<double>("ProjectTotalExpenses");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(

                        new { ProjectId = 1, ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectEndDate = new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectName = "Bathroom", ProjectOwnerId = "7fdacf8b-3c46-4b86-b088-cc7a70a97c80", ProjectStartDate = new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 10000.0, ProjectTotalExpenses = 0.0 },
                        new { ProjectId = 2, ProjectDescription = "Paint and re-tile kitchen walls and floors", ProjectEndDate = new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectName = "Kitchen", ProjectOwnerId = "7fdacf8b-3c46-4b86-b088-cc7a70a97c80", ProjectStartDate = new DateTime(2017, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 12000.0, ProjectTotalExpenses = 0.0 }

                    );
                });

            modelBuilder.Entity("HitApp.Models.ProjectContractor", b =>
                {
                    b.Property<int>("ProjectContractorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractorId");

                    b.Property<int>("ProjectId");

                    b.HasKey("ProjectContractorId");

                    b.HasIndex("ContractorId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectContractors");

                    b.HasData(
                        new { ProjectContractorId = 1, ContractorId = 1, ProjectId = 1 },
                        new { ProjectContractorId = 2, ContractorId = 1, ProjectId = 2 }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HitApp.Models.Expense", b =>
                {
                    b.HasOne("HitApp.Models.Project", "Project")
                        .WithMany("Expenses")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HitApp.Models.ProjectContractor", b =>
                {
                    b.HasOne("HitApp.Models.Contractor", "Contractors")
                        .WithMany("ProjectContractors")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HitApp.Models.Project", "Projects")
                        .WithMany("ProjectContractors")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
