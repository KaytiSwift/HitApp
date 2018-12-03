using HitApp.Controllers.Api;
using HitApp.Models;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HitApp.Tests
{
    public class ApiContractorsControllerTests
    {
        [Fact]
        public void GetAll_Returns_All_Contractors_For_Given_Project()
        {
            var projectId = 42;
            var expectedModel = new List<Contractor>();
            var contractorRepo = Substitute.For<IContractorRepository>();
            contractorRepo.GetContractorsForProjectId(projectId).Returns(expectedModel);
            var underTest = new ContractorsController(contractorRepo);

            var model = underTest.Get(projectId);

            Assert.Same(expectedModel, model);
        }

        //[Fact]
        //public void Post_And_Saves()
        //{
        //    var contractor = new Contractor();
        //    var contractorRepo = Substitute.For<IContractorRepository>();
        //    var underTest = new ContractorsController(contractorRepo);

        //    underTest.Post(contractor, 42);

        //    contractorRepo.Received().Create(contractor);
        //}
    }
}
