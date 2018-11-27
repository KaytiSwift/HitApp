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
            ModelState.Clear();
            return View();
        }

        public IActionResult Delete(int id)
        {
            var model = expenseRepo.GetById(id);
            return View(model);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeleteExpense(int id)
        {
            expenseRepo.Delete(id);
            return RedirectToAction("Details", "Projects", new { Id = id});
            //Dear future us: You will need to pass in project id not expense id to redirect to the right project after delete. Hope you figure it out.//
            //We're going to need to display it on preoject details page using js. Sincerely, past us.//
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = expenseRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Expense expense)
        {
            expenseRepo.Update(expense);
            return RedirectToAction("Details", "Projects", new { Id = expense.ExpenseId });
        }

        [HttpGet("{projectId}")]
        public IEnumerable<Expense> Get(int projectId)
        {
            return expenseRepo.GetExpenseForProjectId(projectId);
        }
    }
}
