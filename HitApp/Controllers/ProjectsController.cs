using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

using Microsoft.AspNetCore.Http;
using System.IO;
using System;

namespace HitApp.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectRepository projectRepo;
        private IExpenseRepository expenseRepo;


        public ProjectsController(IProjectRepository projectRepo, IExpenseRepository expenseRepo)
        {
            this.projectRepo = projectRepo;
            this.expenseRepo = expenseRepo;
        }

        public IActionResult Index()
        {
            var model = projectRepo.GetAll();
            model = from project in model
                   where project.ProjectOwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier) //must be true
                   orderby project.ProjectId // sorts by the date
                   select project;
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = projectRepo.GetById(id);            
            model.ProjectTotalExpenses = expenseRepo.ExpenseTotal(model);
            return View(model);
        }

        public IActionResult Create()
        {
            var project = projectRepo.SetTodaysDate();

            return View(project);
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            project.ProjectOwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            projectRepo.Create(project);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var project = projectRepo.GetById(id);
            return View(project);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            projectRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var project = projectRepo.GetById(id);
            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            project.ProjectOwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            projectRepo.Update(project);
            return RedirectToAction("Details", new { id = project.ProjectId});
        }


    }
}
