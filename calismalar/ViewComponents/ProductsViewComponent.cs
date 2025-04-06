using calismalar.Models;
using Microsoft.AspNetCore.Mvc;

namespace calismalar.ViewComponents
{
	public class ProductsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			//Tasarlanan viewcomponent cagrilip render edildiginde icerisinde calismasini istedigimiz kodlari bu imzada bir metodun icerisine yerlestirmeliyiz.
			//Metot isminin Invoke/InvokeAsync olmasi zorunludur.

			List<Product> datas = new List<Product>
			{
				new Product {ProductName = "Fender Masterbuilt 59 Stratocaster", Price = "6000₺" },
				new Product {ProductName = "Gibson 1959 Les Paul Standart", Price = "6400₺" },
				new Product {ProductName = "DW Drum Workshop Satin 5", Price = "4700₺" },
				new Product {ProductName = "Tama Imperial 22 Hairline Blue", Price = "3600₺" },
				new Product {ProductName = "Vivaldi VI-904 4/4", Price = "6000₺" },
				new Product {ProductName = "Kinglos Advanced Violin KLVP-03A 4/4", Price = "2485₺" },
				new Product {ProductName = "Roland RP30-CRL", Price = "3600₺" },
				new Product {ProductName = "Casio CDP-135BK", Price = "3100₺" }
			};
			return View(datas);
		}
	}
}
