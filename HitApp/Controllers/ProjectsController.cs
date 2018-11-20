﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = projectRepo.GetById(id);
            return View(model);
        }

    }
}
