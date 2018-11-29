﻿using System;
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
        [Display(Name = "Expense Cost")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
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
    }
}
