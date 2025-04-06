using dependency_injection.Models;
using dependency_injection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dependency_injection.Controllers
{
	public class HomeController : Controller
	{
		readonly ILog _log;
  //      public HomeController(ILog log) //Controller bazlý nesne talebi
		//{
  //          _log = log; 
  //      }

        public IActionResult Index([FromServices]ILog log) //Action bazlý nesne talebi
		{
			_log.Log();
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
