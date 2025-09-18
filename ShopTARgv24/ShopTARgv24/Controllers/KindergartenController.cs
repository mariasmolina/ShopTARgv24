using Microsoft.AspNetCore.Mvc;
using ShopTARgv24.Data;
using ShopTARgv24.Models.Kindergarten;

namespace ShopTARgv24.Controllers
{
    public class KindergartenController : Controller
    {
        private readonly ShopTARgv24Context _context;

        public KindergartenController
            (
                ShopTARgv24Context context
            )
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Kindergartens
                .Select(x => new KindergartenIndexViewModel
                {
                    Id = x.Id,
                    GroupName = x.GroupName,
                    ChildrenCount = x.ChildrenCount,
                    KindergartenName = x.KindergartenName,
                    TeacherName = x.TeacherName,
                });

            return View(result);
        }
    }
}
