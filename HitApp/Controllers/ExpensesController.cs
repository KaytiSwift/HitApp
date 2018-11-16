using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HitApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HitApp.Controllers
{
    public class ExpensesController : Controller
    {
        private IExpenseRepository expenseRepo;

        public ExpensesController(IExpenseRepository expenseRepo)
        {
            this.expenseRepo = expenseRepo;
        }

        public IActionResult Create()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            expenseRepo.Create(expense);
            return View();
        }
    }
}
