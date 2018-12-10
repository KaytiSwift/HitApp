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

               new Project() { ProjectId = 1, ProjectName = "Upstairs Bathroom", ProjectStartDate = new DateTime(2018, 10, 2), ProjectEndDate = new DateTime(2018, 11, 2), ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectTotalBudget = 5000.00, ProjectTotalExpenses = 0, ProjectOwnerId = "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a" },
               new Project() { ProjectId = 2, ProjectName = "Kitchen", ProjectStartDate = new DateTime(2018, 10, 5), ProjectEndDate = new DateTime(2018, 11, 2), ProjectDescription = "Paint and re-finish wood floors. Electricty in island and other new appliances", ProjectTotalBudget = 9000.00, ProjectTotalExpenses = 0, ProjectOwnerId = "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a" },
               new Project() { ProjectId = 3, ProjectName = "Basement", ProjectStartDate = new DateTime(2018, 10, 11), ProjectEndDate = new DateTime(2018, 11, 2), ProjectDescription = "Take out part of basement wall, add baseboard heaters", ProjectTotalBudget = 10000.00, ProjectTotalExpenses = 0, ProjectOwnerId = "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a" }


                );
            modelBuilder.Entity<Expense>().HasData(
                new Expense() { ExpenseId = 1, ExpenseName = "TestExpense1", ExpenseNotes = "This is a test", ExpenseCost = 420.00, ProjectId = 1, ProductUrl = "https://www.homedepot.com/p/Warehouse-of-Tiffany-Stella-12-in-Bronze-Accent-Desk-Lamp-with-Red-Dragonfly-Shade-305RBTL/206800480" }
                );
            modelBuilder.Entity<Contractor>().HasData(                
                new Contractor() {ContractorId = 1, ContractorCompany = "TecTile", ContractorName = "Jimmy McDermitt", ContractorEmail = "tectile@live.com", ContractorAdditionalNotes = "Start 10/2, projected end date 11/2. $8,200 labor", ContractorPhone="216-453-0983", ContractorAddress = "1234 Mian Steet", ContractorService="mainly Tile", ContractorZip=44075,  ContractorCity = "Madison", ContractorState ="Ohio"},
                new Contractor() {ContractorId = 2, ContractorCompany = "Streb Electric", ContractorName = "Kevin and Lance", ContractorEmail = "", ContractorAdditionalNotes = "Electric box,electric baseboard heaters and outlets in Kitchen island. $3,376 total", ContractorPhone="440-953-5819", ContractorAddress = "990 Erie Road, Unit P", ContractorService="Electric", ContractorZip=44095,  ContractorCity = "Eastlake",ContractorState ="Ohio"},
                new Contractor() { ContractorId = 3, ContractorCompany = "TecTile", ContractorName = "Jamie Smith", ContractorEmail = "tectile@live.com", ContractorAdditionalNotes = "Works at TecTile with Jimmy", ContractorPhone = "216-453-0983", ContractorAddress = "1234 Mian Steet", ContractorService = "Painting", ContractorZip = 44075, ContractorCity = "Madison", ContractorState = "Ohio" }

                );
            modelBuilder.Entity<ProjectContractor>().HasData(
                new ProjectContractor() {ProjectContractorId = 1, ContractorId = 1, ProjectId = 1},
                new ProjectContractor() { ProjectContractorId = 2, ContractorId = 1, ProjectId = 2 },
                new ProjectContractor() { ProjectContractorId = 3, ContractorId = 1, ProjectId = 3 },
                new ProjectContractor() { ProjectContractorId = 4, ContractorId = 2, ProjectId = 2 },
                new ProjectContractor() { ProjectContractorId = 5, ContractorId = 2, ProjectId = 3 },
                new ProjectContractor() { ProjectContractorId = 6, ContractorId = 3, ProjectId = 1 },
                new ProjectContractor() { ProjectContractorId = 7, ContractorId = 3, ProjectId = 2 },
                new ProjectContractor() { ProjectContractorId = 8, ContractorId = 3, ProjectId = 3 }
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
