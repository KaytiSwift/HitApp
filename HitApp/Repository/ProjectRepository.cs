﻿using HitApp.Data;
using HitApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Repository
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext db) : base(db)
        {

        }

        public int ExpenseTotal(List<Expense> expenses)
        {
            var total = 0;
                foreach(var cost in expenses)
            {
                total = total + cost.ExpenseCost;
            }
            return total;
        }
    }
}
