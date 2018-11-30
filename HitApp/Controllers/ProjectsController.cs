using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HitApp.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectRepository projectRepo;

        public ProjectsController(IProjectRepository projectRepo)
        {
            this.projectRepo = projectRepo;
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
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
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
            projectRepo.Update(project);
            return RedirectToAction("Index");
        }
    }
}
