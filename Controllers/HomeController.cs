using Microsoft.AspNetCore.Mvc;

namespace SPACoreCRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
