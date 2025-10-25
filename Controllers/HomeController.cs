using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CollegeApp.Models;

namespace CollegeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor for dependency injection
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // -------------------------------
        // Default Homepage
        // -------------------------------
        public IActionResult Index()
        {
            return View();
        }

        // -------------------------------
        // Privacy Page
        // -------------------------------
        public IActionResult Privacy()
        {
            return View();
        }

        // -------------------------------
        // Error Page
        // -------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
