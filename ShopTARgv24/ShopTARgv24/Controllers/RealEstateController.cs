using Microsoft.AspNetCore.Mvc;
using ShopTARgv24.Data;

namespace ShopTARgv24.Controllers
{
    public class RealEstateController : Controller
    {
        private readonly ShopTARgv24Context _context;

        public RealEstateController
            (
                ShopTARgv24Context context
            )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
