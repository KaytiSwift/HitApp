using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace HitApp.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectRepository projectRepo;
        private readonly IHostingEnvironment he;

        public ProjectsController(IHostingEnvironment e)
        {
            he = e;
        }

        public ProjectsController(IProjectRepository projectRepo)
        {
            this.projectRepo = projectRepo;
        }

        public IActionResult Index()
        {
            var model = projectRepo.GetAll();
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
                ViewData["fileLocation"] = fileName;
            }

            return View();
        }
    }
}
