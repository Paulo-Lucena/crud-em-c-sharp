using Microsoft.AspNetCore.Mvc;

namespace SalesWebAPI.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
