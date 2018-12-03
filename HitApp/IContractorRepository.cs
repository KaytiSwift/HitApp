using HitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp
{
    public interface IContractorRepository
    {
        IEnumerable<Contractor> GetAll();
        void Create(Contractor contractor);
       
        Contractor GetById(int contractorId);
        void Delete(int id);
        void Update(Contractor contractor);
        Contractor LinkProjectIdToProjectContractor(Contractor contractor, int projectId);
        IEnumerable<Contractor> GetContractorsForProjectId(int projectId);

    }
}
