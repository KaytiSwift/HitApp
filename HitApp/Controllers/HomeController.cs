using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HitApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HitApp.Controllers
{
    public class HomeController : Controller
    {
        private IProjectRepository projectRepo;
        private IExpenseRepository expenseRepo;


        public HomeController(IProjectRepository projectRepo, IExpenseRepository expenseRepo)
        {
            this.projectRepo = projectRepo;
            this.expenseRepo = expenseRepo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Dashboard()
        {
            var model = projectRepo.GetAll();
            model = from project in model
                    where project.ProjectOwnerId == User.FindFirstValue(ClaimTypes.NameIdentifier) //must be true
                    orderby project.ProjectId // sorts by the date
                    select project;

            foreach(var projectTotal in model)
            {
                projectTotal.ProjectTotalExpenses = expenseRepo.ExpenseTotal(projectTotal);

            }
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Resource()
        {
            return View();

        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
