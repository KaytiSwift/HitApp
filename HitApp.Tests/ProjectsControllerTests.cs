using HitApp.Controllers;
using HitApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace HitApp.Tests
{
    public class ProjectControllerTests
    {
        private Project project;
        IProjectRepository projectRepo;
        ProjectsController underTest;
        private IHostingEnvironment e;
        IExpenseRepository expenseRepo;

        public ProjectControllerTests()
        {
            project = new Project();
            projectRepo = Substitute.For<IProjectRepository>();
            underTest = new ProjectsController(projectRepo, expenseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_All_Projects()
        {
            underTest.Index();

            projectRepo.Received().GetAll();
        }
       
        [Fact]
        public void Index_Sets_AllProjects_As_Model()
        {
            var expectedModel = new List<Project>();
            projectRepo.GetAll().Returns(expectedModel);
            var result = underTest.Index();
            
            var model = ((ViewResult)result).Model;

            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var projectId = 42;
            var result = underTest.Details(projectId);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_Correct_View()
        {
            var projectId = 42;
            projectRepo.GetById(projectId).Returns(project);

            var result = underTest.Details(projectId);
            var model = ((ViewResult)result).Model;
            
            Assert.Same(project, model);

        }

        [Fact]
        public void Create_And_Saves()
        {

            underTest.Create(project);

            projectRepo.Received().Create(project);
        }

        [Fact]
        public void Delete_Post_Deletes_The_Project()
        {
            var projectId = 42;

            underTest.DeletePost(projectId);

            projectRepo.Received().Delete(projectId);
        }

        [Fact]
        public void Delete_Redirects_To_Index_After_Deleting()
        {

            var result = underTest.DeletePost(42);
            var redirectResult = (RedirectToActionResult)result;

            Assert.Same("Index", redirectResult.ActionName);
        }

        [Fact]
        public void Edit_Passes_Exisiting_Project_To_View()
        {
            var projectId = 42;
            projectRepo.GetById(projectId).Returns(project);

            var result = underTest.Edit(projectId);
            var model = ((ViewResult)result).Model;

            Assert.Same(project, model);
        }

        [Fact]
        public void Edit_Saves_Updated_Project()
        {

            underTest.Edit(project);

            projectRepo.Received().Update(project);
        }

        [Fact]
        public void Edit_Redirects_To_Index()
        {
            var result = underTest.Edit(project);
            var redirectResult = (RedirectToActionResult)result;

            Assert.Same("Index", redirectResult.ActionName);
        }

    }
}
