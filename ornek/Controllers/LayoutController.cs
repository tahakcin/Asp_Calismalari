using Microsoft.AspNetCore.Mvc;
using ornek.Models;

namespace ornek.Controllers
{
	public class LayoutController : Controller
	{
		//Layout dosyasi ozunde bir .cshtml dosyasidir. Asp.Net Core Mvc uygualamalarinda
		//genellikle "_Layout" ismiyle Views/Shared folder'i altında bulunur. 
		public IActionResult Page1()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Page1(Client model)
		{
			if (!ModelState.IsValid) {
				var message = ModelState.ToList();
				return View(model);
			}
			return View();
		}

		public IActionResult Page2() 
		{
			return View();
		}

		[HttpPost]
		public IActionResult Page2(User model)
		{
			if (ModelState.IsValid) {
				return View(model);
			}
			return View();
		}
		public IActionResult Page3()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Page3(Product model)
		{
			if (!ModelState.IsValid) {
				return View(model);
			}
			
			return View();
		}

	}
}
