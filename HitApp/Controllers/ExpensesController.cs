﻿using System;
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
        private IProjectRepository projectRepo;

        public ExpensesController(IExpenseRepository expenseRepo, IProjectRepository projectRepo)
        {
            this.expenseRepo = expenseRepo;
            this.projectRepo = projectRepo;

        }

        public IActionResult Create(int id)
        {
            var project = projectRepo.GetById(id);
            var model = expenseRepo.AssignProjectId(id);
            model.Project = project;
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
            //Dear future us: You will need to pass in project id not expense id to redirect to the right project after delete. Hope you figure it out.//
            //We're going to need to display it on project details page using js. Sincerely, past us.//
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
