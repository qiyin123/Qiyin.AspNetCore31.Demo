using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Qiyin.AspNetCore31.Demo.Models;

namespace Qiyin.AspNetCore31.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoggerFactory _loggerFactory;

        public HomeController(ILogger<HomeController> logger,
            ILoggerFactory loggerFactory)
        {
            _logger = logger;
            this._loggerFactory = loggerFactory;
        }

        public IActionResult Index()
        {
            //this._loggerFactory.CreateLogger<HomeController>().LogWarning("This is HomeController-Index");
            this._logger.LogWarning("This is HomeController-Index1...");
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
