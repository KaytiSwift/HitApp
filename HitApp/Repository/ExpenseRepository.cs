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

        public Expense AssignProjectId(int projectId) //this method will assign the projectId to the expense
        {
            
            var expense = new Expense() {ProjectId = projectId, ExpenseDatePurchased = DateTime.Today };
            return expense;
        }

        public IEnumerable<Expense> GetExpenseForProjectId(int projectId)
        {
            return from expense in GetAll()
                   where expense.ProjectId == projectId
                   select expense;
        }

        public double ExpenseTotal(Project project)
        {
            //Sums expense costs from list
            double total = project.Expenses.Sum(item => item.ExpenseCost);
            return total;
        }

    }
}
