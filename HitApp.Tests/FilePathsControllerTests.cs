using HitApp.Controllers;
using HitApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HitApp.Tests
{
    public class FilePathsControllerTests
    {
        private FilePath filePath;
        IFilePathRepository FilePathRepo;
        IProjectRepository ProjectRepo;
        FilePathsController underTest;
        private IHostingEnvironment e;
        int id;

        public FilePathsControllerTests()
        {
            filePath = new FilePath();
            FilePathRepo = Substitute.For<IFilePathRepository>();
            underTest = new FilePathsController(ProjectRepo, FilePathRepo, e);
            id = 1;
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index(id);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_All_FilePaths()
        {
            underTest.Index(id);

            FilePathRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_AllFilePaths_As_Model()
        {
            var expectedModel = new List<FilePath>();
            FilePathRepo.GetAll().Returns(expectedModel);
            var result = underTest.Index(id);

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
            var projectId = 1;
            FilePathRepo.GetById(projectId).Returns(filePath);

            var result = underTest.Details(projectId);
            var model = ((ViewResult)result).Model;

            Assert.Same(filePath, model);

        }
    }
}
