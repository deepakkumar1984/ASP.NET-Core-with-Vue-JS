using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectTemplate.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTemplate.Controllers
{
    public class VueController : Controller
    {
        private readonly ILogger<VueController> _logger;

        public VueController(ILogger<VueController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Load(string ID)
        {
            ID = ID.Replace("_", "/");
            return System.IO.File.ReadAllText($"./Components/{ID}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
