using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorsController : ControllerBase
    {
        private IContractorRepository contractorRepo;
        private IProjectContractorRepository projectContractorRepo;

        public ContractorsController(IContractorRepository contractorRepo, IProjectContractorRepository projectContractorRepo)
        {
            this.contractorRepo = contractorRepo;
            this.projectContractorRepo = projectContractorRepo;

        }

        [HttpPost]
        public bool Delete(int id)
        {
            projectContractorRepo.Delete(id);
            return true;
        }

    } 
}
