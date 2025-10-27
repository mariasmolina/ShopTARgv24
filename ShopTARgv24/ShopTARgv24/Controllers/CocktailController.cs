using Microsoft.AspNetCore.Mvc;
using ShopTARgv24.Core.Dto.CocktailDto;
using ShopTARgv24.Core.ServiceInterface;
using ShopTARgv24.Models.Cocktail;

namespace ShopTARgv24.Controllers
{
    public class CocktailController : Controller
    {
        private readonly ICocktailServices _cocktailServices;

        public CocktailController(ICocktailServices cocktailServices)
        {
            _cocktailServices = cocktailServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchCocktail(string cocktailName)
        {
            var dto = await _cocktailServices.GetCocktailByName(cocktailName);

            if (dto == null)
                return View("NotFound");

            var vm = new CocktailViewModel
            {
                Name = dto.Name,
                Category = dto.Category,
                Glass = dto.Glass,
                Instructions = dto.Instructions,
                ImageUrl = dto.ImageUrl,
                Ingredients = dto.Ingredients,
                Measures = dto.Measures
            };

            return View("Recipe", vm);
        }
    }
}
