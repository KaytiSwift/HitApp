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
    }
}
