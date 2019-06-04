using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirtsProject.Models;
using FirtsProject.Services;

namespace FirtsProject.Controllers
{
    public class HomeController : Controller
    {
        public IrepositoryCountries Repository { get;  }
        public HomeController(IrepositoryCountries Repository)
        {
            this.Repository = Repository;
        }

        public IActionResult Index()
        {
           
            var counties = this.Repository.GetCounties();
            return View(counties);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
