using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class Contractor
    {
        public int ContractorId { get; set; }

        [Display(Name = "Company Name")]
        public string ContractorCompany { get; set; }

        [Required]
        [Display(Name = "Contractor Name")]
        public string ContractorName { get; set; }        
        [Display(Name = "Contractor Email Address")]
        public string ContractorEmail { get; set; }
        [Display(Name = "Contractor Phone Number")]
        public string ContractorPhone { get; set; }


        [Display(Name = "Contractor Address")]
        public string ContractorAddress { get; set; }        
        [Display(Name = "Contractor City")]
        public string ContractorCity { get; set; }
        [Display(Name = "Contractor State")]
        public string ContractorState { get; set; }
        [Display(Name = "Contractor Zip Code")]
        public int ContractorZip { get; set; }

        [Display(Name = "Additional Notes")]
        public string ContractorAdditionalNotes { get; set; }
        
        public virtual List<ProjectContractor> ProjectContractors { get; set; }
    }
}
