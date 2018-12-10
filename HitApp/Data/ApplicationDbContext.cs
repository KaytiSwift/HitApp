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

               new Project() { ProjectId = 1, ProjectName = "Upstairs Bathroom", ProjectStartDate = new DateTime(2018, 10, 2), ProjectEndDate = new DateTime(2018, 11, 2), ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectTotalBudget = 3500.00, ProjectTotalExpenses = 0, ProjectOwnerId = "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a" },
               new Project() { ProjectId = 2, ProjectName = "Kitchen", ProjectStartDate = new DateTime(2018, 10, 5), ProjectEndDate = new DateTime(2018, 11, 2), ProjectDescription = "Paint and re-finish wood floors. Electricty in island and other new appliances", ProjectTotalBudget = 3000.00, ProjectTotalExpenses = 0, ProjectOwnerId = "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a" },
               new Project() { ProjectId = 3, ProjectName = "Basement", ProjectStartDate = new DateTime(2018, 10, 11), ProjectEndDate = new DateTime(2018, 11, 2), ProjectDescription = "Take out part of basement wall, add baseboard heaters", ProjectTotalBudget = 2500.00, ProjectTotalExpenses = 0, ProjectOwnerId = "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a" }
               );

            modelBuilder.Entity<Expense>().HasData(
                new Expense() { ExpenseId = 1, ExpenseName = "Vanity", ExpenseNotes = "60 in. Vanity, Home Depot", ExpenseCost = 1039.35, ProjectId = 1, ProductUrl = "https://www.homedepot.com/p/Home-Decorators-Collection-Sonoma-60-in-W-x-22-in-D-Double-Bath-Vanity-in-White-with-Carrara-Marble-Top-with-White-Basins-8105300410/205866623" },
                new Expense() { ExpenseId = 2, ExpenseName = "Bath Towel Set", ExpenseNotes = "Bronze towel bar set from Home Depot", ExpenseCost = 95.96, ProjectId = 1 },
                new Expense() { ExpenseId = 3, ExpenseName = "Mirror", ExpenseNotes = "2 mirrors for vanity", ExpenseCost = 107.74, ProjectId = 1 },
                new Expense() { ExpenseId = 4, ExpenseName = "Tile", ExpenseNotes = "From Home Depot", ExpenseCost = 372.14, ProjectId = 1, ProductUrl= "https://www.homedepot.com/p/TrafficMASTER-Portland-Stone-Beige-18-in-x-18-in-Glazed-Ceramic-Floor-and-Wall-Tile-17-44-sq-ft-case-PT011818HD1PV/205897841" },
                new Expense() { ExpenseId = 5, ExpenseName = "Paint", ExpenseNotes = "BEHR MARQUEE 2 gal. #780F-4 Sparrow One-Coat Hide Satin Enamel Interior Paint and Primer in One", ExpenseCost = 90, ProjectId = 1 },
                new Expense() { ExpenseId = 6, ExpenseName = "Jamie Painting labor", ExpenseNotes = "", ExpenseCost = 150, ProjectId = 1 },
                new Expense() { ExpenseId = 7, ExpenseName = "Jimmy Tile/construction labor", ExpenseNotes = "", ExpenseCost = 2000, ProjectId = 1 },
                new Expense() { ExpenseId = 8, ExpenseName = "Electric labor", ExpenseNotes = "", ExpenseCost = 3450.89, ProjectId = 2 },
                new Expense() { ExpenseId = 9, ExpenseName = "Electric labor", ExpenseNotes = "", ExpenseCost = 2470.12, ProjectId = 3 }


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
