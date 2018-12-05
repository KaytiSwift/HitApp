using Newtonsoft.Json;
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

        [Display(Name = "Company")]
        public string ContractorCompany { get; set; }

        [Required]
        [Display(Name = "Contractor Name (Required)")]
        public string ContractorName { get; set; }        
        [Display(Name = "Email Address")]
        public string ContractorEmail { get; set; }
        [Display(Name = "Phone Number")]
        public string ContractorPhone { get; set; }
        [Display(Name = "Service")]
        public string ContractorService { get; set; }
        [Display(Name = "Website")]
        public string ContractorWebsiteUrl { get; set; }


        [Display(Name = "Address")]
        public string ContractorAddress { get; set; }        
        [Display(Name = "City")]
        public string ContractorCity { get; set; }
        [Display(Name = "State")]
        public string ContractorState { get; set; }
        [Display(Name = "Zip Code")]
        public int? ContractorZip { get; set; }

        [Display(Name = "Additional Notes")]
        public string ContractorAdditionalNotes { get; set; }

        [JsonIgnore]
        public virtual List<ProjectContractor> ProjectContractors { get; set; }
    }
}
