using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Controllers
{
    public class ContractorsController : Controller
    {
        private IContractorRepository contractorRepo;
        private IProjectRepository projectRepo;

        public ContractorsController(IContractorRepository contractorRepo, IProjectRepository projectRepo)
        {
            this.contractorRepo = contractorRepo;
            this.projectRepo = projectRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = contractorRepo.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var project = projectRepo.GetById(id);
            ViewBag.ProjectId = project.ProjectId;
            ViewBag.ProjectName = project.ProjectName;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contractor contractor, int id)
        {
            contractorRepo.Create(contractor);
            contractorRepo.LinkProjectIdToProjectContractor(contractor, id);

            return RedirectToAction("Details", "Projects", new { Id = id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = contractorRepo.GetById(id);
            return View(model);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeletePost(int id)
        {        
            contractorRepo.Delete(id);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = contractorRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Contractor contractor)
        {
            contractorRepo.Update(contractor);
            return RedirectToAction("Details" , new { Id = contractor.ContractorId });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = contractorRepo.GetById(id);
            return View(model);
        }
    }
}
