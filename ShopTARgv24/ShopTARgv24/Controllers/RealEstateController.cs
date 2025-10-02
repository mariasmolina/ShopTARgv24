using Microsoft.AspNetCore.Mvc;
using ShopTARgv24.Core.ServiceInterface;
using ShopTARgv24.Data;
using ShopTARgv24.Models.RealEstate;

namespace ShopTARgv24.Controllers
{
    public class RealEstateController : Controller
    {
        private readonly ShopTARgv24Context _context;
        private readonly IRealEstateServices _realestateServices;

        public RealEstateController
            (
                ShopTARgv24Context context,
                IRealEstateServices realestateServices

            )
        {
            _context = context;
            _realestateServices = realestateServices;
        }
        public IActionResult Index()
        {
            var result = _context.RealEstate
                .Select(x => new RealEstateIndexViewModel
                {
                    Id = x.Id,
                    Area = x.Area,
                    Location = x.Location,
                    RoomNumber = x.RoomNumber,
                    BuildingType = x.BuildingType
                });

            return View(result);
        }
    }
}
