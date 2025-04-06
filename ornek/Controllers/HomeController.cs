using Microsoft.AspNetCore.Mvc;

namespace ornek.Controllers
{
    public class HomeController : Controller
    {
        //Bir sınıfı request alabilir ve respone döndürebilir yani controller yapabilmek için o sınıfı Controller class'ından kalıtım alarak türetmemiz gerekmektedir.
        //Controller sınıfları içerisinde istekleri karşılayan metotlara action metotlar denir.Yani controller sınıfı içerisinde tanımlanan tüm metotlar action metot'tur.

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
