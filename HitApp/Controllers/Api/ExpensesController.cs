using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private IExpenseRepository expenseRepo;

        public ExpensesController(IExpenseRepository expenseRepo)
        {
            this.expenseRepo = expenseRepo;
        }
        
        [HttpGet("{projectId}")]
        public IEnumerable<Expense> Get(int projectId)
        {
            return expenseRepo.GetExpenseForProjectId(projectId);
        }
    }
}
