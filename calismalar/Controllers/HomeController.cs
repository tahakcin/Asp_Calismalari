using Microsoft.AspNetCore.Mvc;


namespace calismalar.Controllers
{
	public class HomeController: Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Products()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		#region ViewComponent
		// PartialView yapilanmasi ihtiyaci olan datalari Controller uzerinden elde edecegi icin Controller'daki maliyeti artirmakta ve SOLID prensiplerine aykiri davranilmasina sebebiyet verebilmektedir.
		// PartialView yapisal olarak Controller uzerinden beslenmektedir.

		// ViewComponent ihtiyaci olan dosyalari Controller uzerinden degil, direkt kendi cs dosyasindan elde edebilmektedir. Boylece Controller'daki luzumsuz maliyeti ortadan kaldirmis olmaktayiz. 
		#endregion
		
	}
}
