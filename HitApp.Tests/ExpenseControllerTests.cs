using HitApp.Controllers;
using HitApp.Models;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HitApp.Tests
{
    public class ExpenseControllerTests
    {
        private Expense expense;
        private IExpenseRepository expenseRepo;
        private ExpensesController underTest;

        public ExpenseControllerTests()
        {
            expense = new Expense();
            expenseRepo = Substitute.For<IExpenseRepository>();
            underTest = new ExpensesController(expenseRepo);
        }

        [Fact]
        public void Create_And_Saves()
        {


            underTest.Create(expense);

            expenseRepo.Received().Create(expense);
        }
    }
}
