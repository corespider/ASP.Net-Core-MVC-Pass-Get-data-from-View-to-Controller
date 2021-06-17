using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCore.ViewToController.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.ViewToController.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Customer cust)
        {
            int customerId = cust.CustomerId;
            string customerName = cust.CustomerName;
            string customerAddress = cust.CustomerAddress;
            string customerEmail = cust.CustomerEmail;
            string customerGender = cust.CustomerGender;
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
