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

        public Contractor AssignProjectIdToContractor(Project project)
        {
            project.ProjectContractors = new List<ProjectContractor>()
            {
                new ProjectContractor() {ProjectId = project.ProjectId}
            };

            var contractor = new Contractor() { ProjectContractors = project.ProjectContractors };

            return contractor;
           
        }
       
    }
}
