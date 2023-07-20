using Microsoft.AspNetCore.Mvc;

namespace DemoProductt.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
