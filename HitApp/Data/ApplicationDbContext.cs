﻿using System;
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
               new Project() { ProjectId = 1, ProjectName = "Bathroom", ProjectStartDate = new DateTime(2017, 9, 19), ProjectEndDate = new DateTime(2018, 1, 18), ProjectContractorInfo = "Jimmy the Tile Guy", ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectTotalBudget = 10000.00 }
               );

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=HitAppV2;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }


    }
}
