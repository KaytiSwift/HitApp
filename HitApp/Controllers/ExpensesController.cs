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

        public IActionResult Create(int id)
        {            
            var model = expenseRepo.AssignProjectId(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            expenseRepo.Create(expense);
            
            return RedirectToAction("Create");
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
            var expense = expenseRepo.GetById(id);
            var projectId = expense.ProjectId;

            expenseRepo.Delete(id);
            return RedirectToAction("Details", "Projects", new { Id = projectId });
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
            return RedirectToAction("Details", "Projects", new { Id = expense.ProjectId });
        }

        //[HttpGet]
        //public IActionResult ReturnToProject(int id)
        //{
        //    var expense = expenseRepo.GetById(id);
        //    var projectId = expense.ProjectId;
        //    return RedirectToAction("Details", "Projects", id = projectId);
            
        //}
    }
}
