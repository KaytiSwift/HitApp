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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
               new Project() { ProjectId = 1, ProjectName = "Bathroom", ProjectStartDate = new DateTime(2017, 9, 19), ProjectEndDate = new DateTime(2018, 1, 18), ProjectContractorInfo = "Jimmy the Tile Guy", ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectTotalBudget = 10000.00 },
               new Project() { ProjectId = 2, ProjectName = "Kitchen", ProjectStartDate = new DateTime(2017, 10, 11), ProjectEndDate = new DateTime(2018, 1, 18), ProjectContractorInfo = "Jimmy the Tile Guy", ProjectDescription = "Paint and re-tile kitchen walls and floors", ProjectTotalBudget = 12000.00 }

                );
            modelBuilder.Entity<Expense>().HasData(
                new Expense() { ExpenseId = 1, ExpenseName = "TestExpense1", ExpenseNotes = "This is a test", ExpenseTotalCost = 420.00, ProjectId = 1}
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
