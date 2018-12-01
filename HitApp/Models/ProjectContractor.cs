using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class ProjectContractor
    {
        public int ProjectContractorId { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Projects { get; set; }

        public int ContractorId { get; set; }
        public virtual Contractor Contractors { get; set; }
    }
}
