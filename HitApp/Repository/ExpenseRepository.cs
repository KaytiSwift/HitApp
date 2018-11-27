using HitApp.Data;
using HitApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Repository
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<Expense> GetExpenseForProjectId(int projectId)
        {
            return from expense in GetAll()
                   where expense.ProjectId == projectId
                   select expense;
        }
    }
}
