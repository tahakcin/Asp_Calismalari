using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using NuGet.Common;
using ornek.Models;
using ornek.Models.ViewModels;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Schema;

namespace ornek.Controllers
{
	// [NonController] //Bu attribute ile de controller dışarıdan istek alamaz. Normal class mantığında kullanılacaksa bu attribute ile request alması engellenebilir.
	public class ProductController : Controller
	{
		//public IActionResult GetProducts()
		//{
		//    X();
		//    Product product = new Product(); // Product nesnesi oluşturuldu
		//    //return View();
		//    //View fonksiyonu bulunduğu action'a ait view(.cshtml) dosyasını tetikleyecek olan fonksiyondur.
		//    //ViewResult result = View(); // İlgili aciton ismiyle aynı olan view'i tetikler.
		//    ViewResult result = View("ahmet"); // Belirtilen view ismindeki dosyayı render eder. 
		//    return result;
		//}

		//public IActionResult Index()
		//{


		//Product product = new Product();
		//product.ID = 3;
		//product.ProductName = "Test";
		//product.Quantity = 6;

		//Product product2 = new Product();
		//product2.ID = 4;
		//product2.ProductName = "Test2";
		//product2.Quantity = 4;

		//Product product3 = new Product();
		//product3.ID = 5;
		//product3.ProductName = "Test3";
		//product3.Quantity = 8;

		//var productList = new List<Product>();
		//productList.Add(product);
		//productList.Add(product2);
		//productList.Add(product3);

		#region Model Bazli Veri Gönderimi
		//return View(productList);
		// Bu gönderimle aynı zamanda kullanıcıdan veri alabiliriz.
		#endregion
		#region Veri Tasima Kontrolleri

		#region ViewBag
		//View'e taşınacak data'yı dynamic şekilde tanımlanan bir degiskenle tasimamizi saglayan bir veri tasima kontorludur.

		//ViewBag.products = productList;
		#endregion
		#region ViewData
		// ViewBag'de oldugu gibi action'daki data'yi view'e tasimamizi saglayan bir kontorldur.
		// Bu kontrol veriyi boxing ederek tasir. Bu sebeple view'de verinin unboxing edilerek kullanılması gerekir. 
		//ViewData["products"] = productList;

		#endregion
		#region TempData
		// ViewData'da oldugu gibi action'daki data'yi view'e tasimamizi saglayan bir kontorldur.
		// Farkli bir aciton'a yonlendirme soz konusu oldugunda viewbag veya viewdata ile veri tasinamazken tempdata ile veri tasinabilir.
		// Bunu da tempdata'nın cookie kullanmasiyle iliskilendirebiliriz.
		// Burada routing durumlarinda serialize/deserialize islemleri unutulmamalidir.
		//string data = JsonSerializer.Serialize(productList);
		//TempData["products"] = data;
		#endregion
		#endregion

		//ViewBag.x = 5;
		//ViewData["x"] = 5;
		//TempData["x"] = 5;

		//return RedirectToAction("Index2", "Product");
		//return View();
		//}

		//public IActionResult Index2()
		//{
		//var v1 = ViewBag.x;
		//var v2 = ViewData["x"];
		//var v3 = TempData["x"];

		//	var data = TempData["products"].ToString();

		//	List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
		//	return View();
		//}

		#region ViewResult
		//public ViewResult GetProducts()
		//{
		//    ViewResult result =  View();
		//    return result;
		//}
		#endregion
		#region PartialViewResult
		//public PartialViewResult GetProducts()
		//{
		//    PartialViewResult result = PartialView();
		//    return result;
		//}
		#endregion
		#region JsonResult
		//public JsonResult GetProducts()
		//{
		//    JsonResult result = Json(new Product
		//    {
		//        ID = 8,
		//        ProductName = "masaLambasi",
		//        Quantity = 84
		//    });
		//    return result;
		//}
		#endregion
		#region EmptyResult
		//public EmptyResult GetProducts()
		//{
		//    return new EmptyResult();
		//}
		#endregion
		#region ContentResult
		//public ContentResult GetProducts()
		//{
		//    ContentResult result = Content("Sebepsiz bos yere ayrilacaksannn...");
		//    return result;
		//}
		#endregion
		#region ActionResult
		//public ActionResult GetProducts()
		//{
		//    int a = 3;
		//    if (a == 2)
		//    {
		//        // code lines...
		//        return Json(new object());
		//    }
		//    else if (a == -3)
		//    {
		//        return Content("daskjerahıfauı");
		//    }
		//    return View();
		//}
		#endregion
		#region IActionResult
		//public IActionResult GetProducts()
		//{
		//    // ActionResult'un interface'i yani arayüzüdür. 
		//}
		#endregion
		#region NonAction Attribute
		//Controller yapısında sadece control işlemleri yapan action metotlar bulunmalıdır. Çünkü burada bulunan metotlara request gelmektedir. Buradaki fonksiyonlar bir iş mantığı üstlenmemeli, iş mantığı üstlenen katmanlara gerekli taleplerde bulunmalıdır.
		//Buna binaen eğer bir iş mantığı olan bir fonksiyon tanımlanacaksa da bu fonksiyonun başında nonaction ifadesi köşeli parantez içinde eklenmelidir.
		// Böylelikle bu fonksiyonlar dışarıdan request karşılamazlar.
		//[NonAction]
		//public void X()
		//{

		//}
		#endregion

		//public IActionResult GetProducts()
		//{
		//	Product product = new Product()
		//	{
		//		ID = 1,
		//		ProductName = "A Product",
		//		Quantity = 13,
		//	};

		//	User user = new User()
		//	{
		//		ID = 1,
		//		Name = "Hilmi",
		//		LastName = "İntepe"
		//	};

		//UserProduct userProduct = new UserProduct()
		//{
		//	User = user,
		//	Product = product
		//};

		//return View(userProduct);
		//var userProduct = (product, user);
		//Burada userProduct artık bir tuple nesnesidir.
		//return View(userProduct);
		//ViewBag.Mesaj = "Ürünler başarıyla sıralandı."; // Burada olusuturulan veri dolayli yoldan list partial'a gonderilmis oldu.
		//return View();

		//	return View(user);
		//}




		#region Data'larin Name'lerini Action Metodun Parametreleriyle Bind Etme
		//[HttpPost] // fonksiyonun post oldugu boyle belirtilir. Default olarak get durumundadır.
		//public IActionResult CreateProduct(string txtProductName, string txtQuantity) //Request neticesinde gelen data'lar Action fonksiyonlarda parametrelerden yakalanmaktadir.										 
		//{
		//	return View();
		//}
		#endregion
		#region Kullanicidan Alinan Verileri Nesnede Tutma
		//public IActionResult CreateProduct()
		//{
		//var product = new Product()
		//{
		//	ProductName = "A Product",
		//	Quantity = 5
		//};
		//return View(product);
		//Buraya eklenen nesne view tarafına gonderilir ve orada yapilan degisiklikler yeni bir nesne olusturmaz, gonderilen mevcut nesnenin uzerine yazilir.		
		//	return View();
		//}

		//[HttpPost]
		//public IActionResult CreateProduct(Product product)
		//{
		//	return View();
		//	//Form icerisindeki input nesneleri POST edildiginde bu nesnelere karsilik gelen property'leri sahip bir nesneyle otomatik olarak bind edilir.
		//}
		#endregion
		#region IFormCollection ile Kullanicidan Veri Alma
		//public IActionResult GetData()
		//{
		//	return View();
		//}

		//[HttpPost]
		//public IActionResult GetData(IFormCollection datas)
		//{
		//	var value1 = datas["txtValue1"].ToString();
		//	var value2 = datas["txtValue2"].ToString();
		//	var value3 = datas["txtValue3"].ToString();
		//	return View();
		//}
		#endregion
		#region QueryString ile Kullanicidan Dolayli Olarak Veri Alma
		//Guvenlik gerektirmeyen bilgilerin url uzerinden tasinmasi icin kullanilan yapilanmadir.
		//Yapilan requestin turu her ne olursa olsun query strimg degerleri tasinabilir.

		//public IActionResult GetData(string a, string b)
		//{
		////action metodun yanina ? isareti konur ve degerelr yazilir, 2 deger verilecekse arasına AND sembolu koyulur.
		//	return View();
		//}

		//public IActionResult GetData()
		//{
		//	var queryString = Request.QueryString; //Request yapilan endpointe query string parametresi eklemnmis mi eklenmemis mi bununla ilgili bilgi verir.
		//	var a = Request.Query["a"].ToString();
		//	var b = Request.Query["b"].ToString();
		//	return View();
		//}

		//public IActionResult GetData(QueryData data)
		//{
		//	//var queryString = Request.QueryString; //Request yapilan endpointe query string parametresi eklemnmis mi eklenmemis mi bununla ilgili bilgi verir.
		//	//var a = Request.Query["a"].ToString();
		//	//var b = Request.Query["b"].ToString();
		//	return View();
		//}

		#endregion
		#region Route Parameter ile Kullanicidan Veri Alma
		//public IActionResult GetData(string a, string b, string id)
		//{
		//	var values = Request.RouteValues;
		//	return View();
		//}




		#endregion
		#region Route class ile Veri Alma
		//public IActionResult GetData(RouteStruct datas)
		//{
		//	var values = Request.RouteValues;
		//	return View();
		//}
		#endregion
		#region Header ile Veri Alma
		//public IActionResult GetData()
		//{
		//	var headers = Request.Headers;
		//	return View();
		//}
		#endregion
		#region Ajax ile Veri Alma
		//public IActionResult GetData()
		//{
		//	return View();
		//}


		//[HttpPost]		
		//public IActionResult GetData(AjaxData ajaxData)
		//{
		//	return View();
		//}
		#endregion
		#region Tuple Nesnesi POST Etme ve Yakalama
		//public IActionResult CreateProduct()
		//{
		//	var tuple = (new Product(), new User());
		//	return View(tuple);
		//}

		//[HttpPost]
		//public IActionResult CreateProduct([Bind(Prefix = "Item1")]Product product, [Bind(Prefix = "Item2")] User user)
		//{
		//	return View();
		//}
		#endregion
		#region  Validation
		//Bir degerin icinde bulundugu sartlara uygun olmasi durumudur.Belirlenen kosul ve amaca uygun olma durumunun check edilmesidir.
		//Bu kontrole gore verinin isleme tabi tutulmasi durumudur.
		//Hem Client tarafinda hem de server tarafinda uygulanmalidir.
		//if veya switch'le yapilan validation'lar hem maliyetli bir kod olusturur hem de yonetilebilirligi ve surdurulebilirligi dusuk bir yapi ortaya koyar.
		//Validation'lar ilgili nesneye bildirilir. Bunu saglayan attribute'lara annotations denir.  Burada Client.cs tarafinda bunu yapacagiz.
		//public IActionResult CreateProduct()	
		//{
		//	return View();
		//}
		//[HttpPost]
		//public IActionResult CreateProduct(Client model)
		//{
		//	//Model State: MVC'de bir type'in data annotation'larinin durumunu check eden ve geriye sonuc donduren bir property'dir.
		//	if (!ModelState.IsValid) {
		//		//Loglama
		//		//Kullaniciyi bilgilendirme

		//		//var messages = ModelState.ToList();


		//		return View(model);//model return edilmezse asp-validation-for direktifi islevsiz olur. 
		//	}



		//	return View();
		//}
		#region ModelMetadata ile validation islemini farkli bir sinifa yukleme
		//ModelMetadata prensibinde validation islemi yapmak istedigimiz sinif icin farkli bir sinif olsutururuz ve validation islemlerini bu sinifta gerceklestiririz.
		//Boylelikle SOLID prensiplerinden "Single Responsibility" saglanmis olur.

		//public IActionResult CreateProduct()
		//{
		//	return View();
		//}

		//[HttpPost]
		//public IActionResult CreateProduct(Customer model)
		//{
		//	if (!ModelState.IsValid) {
		//		return View(model);
		//	}

		//	return View();
		//}

		#endregion
		#region FluentValidation kutuphanesi ile Validation islemleri
		//ModelMetaData'da oldugu gibi SOLID prensiplerini saglayan bir kutuphanedir. Kodun  yonetimi ve surdurulebilirlik konusunda bizlere avantaj saglar.
		//public IActionResult CreateProduct()
		//{
		//	return View();
		//}
		//[HttpPost]
		//public IActionResult CreateProduct(Client model)
		//{
		//	if (!ModelState.IsValid) {
		//		return View(model);
		//	}


		//	return View();
		//}


		#endregion

		#region Validation in Client-Side

		//wwwroot folder'ına ekledigimiz jQuery kutuphaneleri ile client tarafinda validation islemi gerceklestirilir. Boylelikle server-side uzerindeki yuk azaltılmıs olur. 
		//public IActionResult CreateProduct()
		//{
		//	return View();
		//}

		//[HttpPost]
		//public IActionResult CreateProduct(Client model)
		//{
		//	if (!ModelState.IsValid) {
		//		return View(model);
		//	}

		//	return View();
		//}

		#endregion


		#endregion
		//Ctrl M,P  => open all region
		//Ctrl M,O => close all region

		#region Moduler Tasarim Yapilanmasi
		#region Partial
		public IActionResult Ahmet()
		{
			return View();
		}


		#endregion


		#endregion






	}
}
