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

        public IActionResult Index()
        {
            var model = contractorRepo.GetAll();
            return View(model);
        }

        public IActionResult Create(Contractor contractor)
        {
            contractorRepo.Create(contractor);
            return View();
        }

        public IActionResult Create(int projectId)
        {
            return View();
        }
    }
}
