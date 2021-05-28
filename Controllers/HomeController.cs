using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcSample.Data;
using MvcSample.Data.Entities;
using MvcSample.Data.Repositories;
using MvcSample.Models;
using MvcSample.Queries;

namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetEmployeeQuery getEmployeeQuery;
        public HomeController(ILogger<HomeController> logger, IGetEmployeeQuery getEmployeeQuery)
        {
            _logger = logger;
            this.getEmployeeQuery = getEmployeeQuery;
        }
        public IActionResult Index()
        {
            // ServiceLocator.GetEmployeeRepository();
            var vm = new IndexViewModel
            {
                Employee = this.getEmployeeQuery.Execute()
            };
            return View(vm);
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
