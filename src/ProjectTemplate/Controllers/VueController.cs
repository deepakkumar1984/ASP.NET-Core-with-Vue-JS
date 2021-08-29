using ASP.NET_Core_SPA_with_Vue_Js2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_SPA_with_Vue_Js2.Controllers
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

        public string Load(string path)
        {
            return System.IO.File.ReadAllText($"./{path}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
