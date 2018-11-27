using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string ExpenseName { get; set; }

        [Required]
        [Display(Name = "Total Cost")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public double ExpenseTotalCost { get; set; }

        [Display(Name = "Notes")]
        public string ExpenseNotes { get; set; }

        [Required]
        [Display(Name = "Project Id")]
        public int ProjectId { get; set; }
    }
}
