using HitApp.Controllers;
using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
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
        private IProjectRepository projectRepo;

        public ExpenseControllerTests()
        {
            expense = new Expense();
            expenseRepo = Substitute.For<IExpenseRepository>();
            underTest = new ExpensesController(expenseRepo , projectRepo);
        }

        [Fact]
        public void Create_And_Saves()
        {


            underTest.Create(expense);

            expenseRepo.Received().Create(expense);
        }

        [Fact]
        public void Delete_Passes_Correct_Expense_To_View()
        {
            var expenseId = 42;
            var expectedExpense = new Expense();

            expenseRepo.GetById(expenseId).Returns(expectedExpense);

            var result = underTest.Delete(expenseId);
            var model = ((ViewResult)result).Model;

            Assert.Same(expectedExpense, model);
        }

        [Fact]
        public void Delete_Expense_Deletes_The_Expense()
        {
            var expenseId = 42;
            underTest.DeleteExpense(expenseId);

            expenseRepo.Received().Delete(expenseId);
        }

        [Fact]
        public void Delete_Redirects_To_Project_Details_After_Delete()
        {
            var expenseId = 42;
            var result = underTest.DeleteExpense(expenseId);
            var redirectResult = (RedirectToActionResult)result;

            Assert.Same("Details", redirectResult.ActionName);
        }

        [Fact]
        public void Edit_Passes_Correct_Expense_To_View()
        {
            var expenseId = 42;
            var expectedExpense = new Expense();

            expenseRepo.GetById(expenseId).Returns(expectedExpense);

            var result = underTest.Edit(expenseId);
            var model = ((ViewResult)result).Model;

            Assert.Same(expectedExpense, model);
        }

        [Fact]
        public void Edit_Saves_Updated_Expense()
        {
            var expense = new Expense();
            underTest.Edit(expense);

            expenseRepo.Received().Update(expense);
        }

        [Fact]
        public void Edit_Redirects_To_Project_Details()
        {
            var expense = new Expense();
            var result = underTest.Edit(expense);
            var redirectResult = (RedirectToActionResult)result;

            Assert.Same("Details", redirectResult.ActionName);
        }

        [Fact]
        public void Create_Sets_ProjectId_To_Correct_Project()
        {
            var projectId = 42;            
            
            underTest.Create(projectId);

            expenseRepo.Received().AssignProjectId(projectId);

        }
    }
}
