using HitApp.Data;
using HitApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Repository
{
    public class ProjectContractorRepository : Repository<ProjectContractor>, IProjectContractorRepository
    {
        public ProjectContractorRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
