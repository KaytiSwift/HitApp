using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [DisplayName("Start Date")]
        public DateTime ProjectStartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime ProjectEndDate { get; set; }

        [DisplayName("Project Description")]
        public string ProjectDescription { get; set; }

        [DisplayName("Contractor Info")]
        public string ProjectContractorInfo { get; set; }

        [DisplayName("Total Budget")]
        public double ProjectTotalBudget { get; set; }
    }
}
