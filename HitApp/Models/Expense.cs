using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public double ExpenseTotalCost { get; set; }
        public string ExpenseNotes { get; set; }
    }
}
