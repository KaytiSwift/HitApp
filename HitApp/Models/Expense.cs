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
        [Display(Name = "Name")]
        public string ExpenseName { get; set; }
        [Display(Name = "Total Cost")]
        public double ExpenseTotalCost { get; set; }
        [Display(Name = "Notes")]
        public string ExpenseNotes { get; set; }
    }
}
