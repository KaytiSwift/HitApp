using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HitApp.Models;

namespace HitApp
{
    public interface IExpenseRepository
    {
        void Create(Expense expense);
    }
}
