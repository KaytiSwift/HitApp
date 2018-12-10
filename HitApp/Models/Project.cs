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

        public string ProjectOwnerId { get; set; }

        [Display(Name = "Display On Dashboard")]
        [DefaultValue(false)]
        public bool ProjectIsOnDashboard { get; set; }

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

        [Display(Name="Total Budget")]
        [DisplayFormat(DataFormatString = "${0:#,0.00}", ApplyFormatInEditMode = false)]
        public double ProjectTotalBudget { get; set; }


        public virtual List<Expense> Expenses { get; set; }

        [Display(Name = "Total Expenses")]
        [DisplayFormat(DataFormatString = "${0:#,0.00}", ApplyFormatInEditMode = false)]
        public double ProjectTotalExpenses { get; set; }
 
        public virtual List<ProjectContractor> ProjectContractors { get; set; }

        public virtual ICollection<FilePath> FilePaths { get; set; }

    }
}
