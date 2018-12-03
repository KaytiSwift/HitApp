using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace HitApp.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectRepository projectRepo;
        private readonly IHostingEnvironment he;

        public ProjectsController(IProjectRepository projectRepo, IHostingEnvironment e)
        {
            this.projectRepo = projectRepo;
            he = e;
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

        public IActionResult ImageUpload(IFormFile image)
        {
            if(image != null && image.Length > 0)
            {
                var fileName = Path.Combine(he.WebRootPath, Path.GetFileName(image.FileName));
                image.CopyTo(new FileStream(fileName, FileMode.Create));
                ViewData["fileLocation"] = "/" + Path.GetFileName(image.FileName);
            }

            return View();
        }
    }
}
