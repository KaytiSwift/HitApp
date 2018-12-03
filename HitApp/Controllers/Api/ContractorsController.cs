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

        // GET list of comments for each Todo
        [HttpGet("{id}")]
        public IEnumerable<Contractor> Get(int id)
        {
            var contractors = contractorRepo.GetContractorsForProjectId(id);
            return contractors;
        }

        [HttpPost("{id}")]
        public bool Delete(int id)
        {
            projectContractorRepo.Delete(id);
            return true;
        }

    } 
}
