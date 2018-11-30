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
            var model = contractorRepo.AssignProjectIdToContractor(project);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contractor contractor)
        {
            contractorRepo.Create(contractor);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = contractorRepo.GetById(id);
            return View(model);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeleteContractor(int id)
        {
            var contractor = contractorRepo.GetById(id);
            var thing = contractor.ProjectContractors;
            
            
            contractorRepo.Delete(id);
            
            return RedirectToAction("Details", "Projects", new { Id = projectId });
        }
    }
}
