using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }

        [Required]
        [Display(Name = "Product/Labor Expense Name (Required)")]
        public string ExpenseName { get; set; }

        [Required]
        [Display(Name = "Cost")]
        [DisplayFormat(DataFormatString = "${0:#,0.00}", ApplyFormatInEditMode = false)]
        public double ExpenseCost { get; set; }

        [Display(Name = "Date Purchased")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false,
               DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ExpenseDatePurchased { get; set; }

        [Display(Name = "Notes")]
        public string ExpenseNotes { get; set; }

        [Required]
        [Display(Name = "Project Id")]
        public int ProjectId { get; set; }

        [Display(Name = "Product Link")]
        public string ProductUrl { get; set; }

        public virtual Project Project { get; set; }

    }
}
