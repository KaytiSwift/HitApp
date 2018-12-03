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

        public ContractorsController(IContractorRepository contractorRepo)
        {
            this.contractorRepo = contractorRepo;
        }

        // GET list of comments for each Todo
        [HttpGet("{id}")]
        public IEnumerable<Contractor> Get(int id)
        {
            var contractors = contractorRepo.GetContractorsForProjectId(id);
            return contractors;
        }

        //[HttpPost]  
        //public bool Remove([FromBody]ProjectContractor projectontractor, int id /*project Id*/)
        //{
        //    contractorRepo.Delete(projectContractors);
        //    return true;
        //}
    }
}
