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
    public class HomeControllerTests
    {
        IProjectRepository projectRepo;
        HomeController underTest;
        IExpenseRepository expenseRepo;


        public HomeControllerTests()
        {
            projectRepo = Substitute.For<IProjectRepository>();
            underTest = new HomeController(projectRepo, expenseRepo);
        }

        [Fact]
        public void Dashboard_Returns_A_View()
        {
            var result = underTest.Dashboard();

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Dashboard_Gets_All_Projects()
        {
            underTest.Dashboard();

            projectRepo.Received().GetAll();
        }
        [Fact]
        public void Dashboard_Sets_AllProjects_As_Model()
        {
            var expectedModel = new List<Project>();
            projectRepo.GetAll().Returns(expectedModel);
            var result = underTest.Dashboard();
            var model = ((ViewResult)result).Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
