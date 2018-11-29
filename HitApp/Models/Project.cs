using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; }        

        [Display(Name="Project Name")]
        public string ProjectName { get; set; }

        [Display(Name="Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false,
               DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ProjectStartDate { get; set; }

        [Display(Name="End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false,
               DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ProjectEndDate { get; set; }

        [Display(Name="Project Description")]
        public string ProjectDescription { get; set; }

        [Display(Name="Contractor Info")]
        public string ProjectContractorInfo { get; set; }

        [Display(Name="Total Budget")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public double ProjectTotalBudget { get; set; }


        public virtual List<Expense> Expenses { get; set; }

        public int ProjectTotalExpenses { get; set; }

    }
}
