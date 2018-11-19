using HitApp.Controllers;
using HitApp.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace HitApp.Tests
{
    public class ProjectControllerTests
    {
        IProjectRepository projectRepo;
        ProjectsController underTest;


        public ProjectControllerTests()
        {
            projectRepo = Substitute.For<IProjectRepository>();
            underTest = new ProjectsController(projectRepo);
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
            var expectedModel = new Project();
            projectRepo.GetById(projectId).Returns(expectedModel);

            var result = underTest.Details(projectId);
            var model = ((ViewResult)result).Model;
            
            Assert.Same(expectedModel, model);

        }

    }
}
