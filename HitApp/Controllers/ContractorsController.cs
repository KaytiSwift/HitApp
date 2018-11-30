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

       
    }
}
