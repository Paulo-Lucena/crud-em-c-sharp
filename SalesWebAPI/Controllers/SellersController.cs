using Microsoft.AspNetCore.Mvc;
using SalesWebAPI.Interfaces;
using SalesWebAPI.Services;
using SalesWebAPI.Models;

namespace SalesWebAPI.Controllers
{
    public class SellersController : Controller
    {
        private ISellerService _sellerService;
        public SellersController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
