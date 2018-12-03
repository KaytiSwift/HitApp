using HitApp.Data;
using HitApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Repository
{
    public class ContractorRepository : Repository<Contractor>, IContractorRepository
    {
        public ContractorRepository(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<Contractor> GetContractorsForProjectId(int projectId)
        {
            return from contractors in GetAll()
                   from projectContractor in contractors.ProjectContractors
                   where projectContractor.ProjectId == projectId
                   select projectContractor.Contractors;
        }


       
        public Contractor LinkProjectIdToProjectContractor(Contractor contractor, int projectId) 
            {
                var projCont = new ProjectContractor()
                {
                    ProjectId = projectId,
                    ContractorId = contractor.ContractorId
                };

                contractor.ProjectContractors = new List<ProjectContractor>(){projCont};
                Save();  
                return contractor;

        }



    }
}
