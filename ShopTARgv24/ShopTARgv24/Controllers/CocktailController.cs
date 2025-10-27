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
        public IActionResult SearchCocktail(string cocktailName)
        {
            // You can implement search by name if needed
            return RedirectToAction(nameof(Recipe));
        }

        [HttpGet]
        public async Task<IActionResult> Recipe()
        {
            var dto = new CocktailResultDto();
            await _cocktailServices.GetRandomCocktailRecipe(dto);

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

            return View(vm);
        }
    }
}
