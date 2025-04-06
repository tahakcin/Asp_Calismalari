using Microsoft.AspNetCore.Mvc;
using RouteYapilanmasi.Models;
using System.Diagnostics;
using System.Net.Mime;

namespace RouteYapilanmasi.Controllers
{
	//Attribute Routing; genelde API custom routing'de kullanilir.
	//[controller]/[action]/{id?}
	//[Route("[controller]/[action]")]
	[Route("anasayfa")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		[Route("ilk/{id:int?}")]
		public IActionResult Index(int? id)
		{
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
