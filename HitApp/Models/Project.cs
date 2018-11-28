using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false,
               DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ProjectStartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false,
               DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ProjectEndDate { get; set; }

        [DisplayName("Project Description")]
        public string ProjectDescription { get; set; }

        [DisplayName("Contractor Info")]
        public string ProjectContractorInfo { get; set; }

        [DisplayName("Total Budget")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public double ProjectTotalBudget { get; set; }


        public virtual List<Expense> Expenses { get; set; }

    }
}
