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
    public class ContractorsControllerTests
    {
        private Contractor contractor;
        private IContractorRepository contractorRepo;
        private ContractorsController underTest;
        private IProjectRepository projectRepo;


        public ContractorsControllerTests()
        {
            contractor = new Contractor();
            contractorRepo = Substitute.For<IContractorRepository>();
            underTest = new ContractorsController(contractorRepo, projectRepo);
        }

        [Fact]
        public void Index_Gets_All_Contractors()
        {
            underTest.Index();

            contractorRepo.Received().GetAll();

        }
        [Fact]
        public void Index_Returns_All_Contractors()
        {
            var expected = new List<Contractor>();
            contractorRepo.GetAll().Returns(expected);
            var result = underTest.Index();
            var model = ((ViewResult)result).Model;

            Assert.Same(expected, model);
        }
        [Fact]
        public void Create_And_Saves_Contractor()
        {
            underTest.Create(contractor , 1);

            contractorRepo.Received().Create(contractor);
        }

        //[Fact]
        public void Delete_Passes_Correct_Contractor_To_View()
        {
            var contractorId = 42;
            var expectedContractor = new Contractor();

            contractorRepo.GetById(contractorId).Returns(expectedContractor);

            var result = underTest.Delete(contractorId);
            var model = ((ViewResult)result).Model;

            Assert.Same(expectedContractor, model);
        }

        [Fact]
        public void Delete_Redirects_To_Project_Details_After_Delete()
        {
            var contractorId = 42;
            var result = underTest.DeletePost(contractorId);
            var redirectResult = (RedirectToActionResult)result;

            Assert.Same("Index", redirectResult.ActionName);
        }

        [Fact]
        public void Edit_Passes_Correct_Contractor_To_View()
        {
            var contractorId = 42;
            var expectedContractor = new Contractor();

            contractorRepo.GetById(contractorId).Returns(expectedContractor);

            var result = underTest.Edit(contractorId);
            var model = ((ViewResult)result).Model;

            Assert.Same(expectedContractor, model);
        }

        [Fact]
        public void Edit_Saves_Updated_Contractor()
        {
            var contractor = new Contractor();
            underTest.Edit(contractor);

            contractorRepo.Received().Update(contractor);
        }

        [Fact]
        public void Edit_Redirects_To_Contractor_Index()
        {
            var contractor = new Contractor();
            var result = underTest.Edit(contractor);
            var redirectResult = (RedirectToActionResult)result;

            Assert.Same("Details", redirectResult.ActionName);
        }

        [Fact]
        public void Details_Returns_Correct_View()
        {
            var contractorId = 42;
            contractorRepo.GetById(contractorId).Returns(contractor);

            var result = underTest.Details(contractorId);
            var model = ((ViewResult)result).Model;

            Assert.Same(contractor, model);

        }


    }    
}
