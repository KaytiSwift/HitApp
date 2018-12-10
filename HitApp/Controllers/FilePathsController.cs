using HitApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HitApp.Controllers
{
    public class FilePathsController : Controller
    {
        private IFilePathRepository filePathRepo;
        private IProjectRepository projectRepo;
        private readonly IHostingEnvironment he;

        public FilePathsController(IProjectRepository projectRepo, IFilePathRepository filePathRepo, IHostingEnvironment e)
        {
            this.projectRepo = projectRepo;
            this.filePathRepo = filePathRepo;
            he = e;
        }

        public IActionResult ImageUpload(int id, IFormFile upload)
        {
            var project = projectRepo.GetById(id);
            if (upload != null && upload.Length > 0)
            {
                var photo = new FilePath
                {
                    FileName = Guid.NewGuid().ToString() + Path.GetExtension(upload.FileName),
                    FileType = FileType.Photo
                };
                project.FilePaths = new List<FilePath>();
                project.FilePaths.Add(photo);
                string filePath = Path.Combine(he.WebRootPath + "/UserImages/" + photo.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {

                    upload.CopyTo(stream);


                }
                projectRepo.Save();
                var path = "/UserImages/" + photo.FileName;
                ViewBag.Image = path;
            }
            ViewBag.ProjectName = project.ProjectName;
            ViewBag.ProjectId = id;
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = filePathRepo.GetById(id);
            model.Project.ProjectOwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(model);
        }

        public IActionResult Index(int id)
        {            
            var model = filePathRepo.GetAll();
            model = from filePath in model
                    where filePath.ProjectId == id //must be true  
                    where filePath.Project.ProjectOwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier)
                    orderby filePath.ProjectId // sorts by the date
                    select filePath;
            ViewBag.ProjectId = id;
            var project = projectRepo.GetById(id);
            ViewBag.ProjectName = project.ProjectName;
            
            return View(model);
        }
    }
}
