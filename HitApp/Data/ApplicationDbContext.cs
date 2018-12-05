using System;
using System.Collections.Generic;
using System.Text;
using HitApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HitApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ProjectContractor> ProjectContractors { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(

               new Project() { ProjectId = 1, ProjectName = "Bathroom", ProjectStartDate = new DateTime(2017, 9, 19), ProjectEndDate = new DateTime(2018, 1, 18), ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectTotalBudget = 10000.00, ProjectTotalExpenses = 0, ProjectOwnerId = "7fdacf8b-3c46-4b86-b088-cc7a70a97c80" },
               new Project() { ProjectId = 2, ProjectName = "Kitchen", ProjectStartDate = new DateTime(2017, 10, 11), ProjectEndDate = new DateTime(2018, 1, 18), ProjectDescription = "Paint and re-tile kitchen walls and floors", ProjectTotalBudget = 12000.00, ProjectTotalExpenses = 0, ProjectOwnerId = "7fdacf8b-3c46-4b86-b088-cc7a70a97c80" }


                );
            modelBuilder.Entity<Expense>().HasData(
                new Expense() { ExpenseId = 1, ExpenseName = "TestExpense1", ExpenseNotes = "This is a test", ExpenseCost = 420.00, ProjectId = 1, ProductUrl = "https://www.homedepot.com/p/Warehouse-of-Tiffany-Stella-12-in-Bronze-Accent-Desk-Lamp-with-Red-Dragonfly-Shade-305RBTL/206800480" }
                );
            modelBuilder.Entity<Contractor>().HasData(
                new Contractor() {ContractorId = 1, ContractorCompany = "Self", ContractorName = "Jimmy McDermitt", ContractorEmail = "tectile@live.com", ContractorAdditionalNotes = "Jimmy the tile guy", ContractorCity = "Madison", ContractorState ="Ohio"}
                );
            modelBuilder.Entity<ProjectContractor>().HasData(
                new ProjectContractor() {ProjectContractorId = 1, ContractorId = 1, ProjectId = 1},
                new ProjectContractor() { ProjectContractorId = 2, ContractorId = 1, ProjectId = 2 }
                );
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=HitAppV2;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

    
    }
}
