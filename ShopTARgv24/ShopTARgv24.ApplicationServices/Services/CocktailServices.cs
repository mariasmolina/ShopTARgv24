using Newtonsoft.Json;
using ShopTARgv24.Core.Dto.CocktailDto;
using ShopTARgv24.Core.ServiceInterface;
using System.Net;

namespace ShopTARgv24.ApplicationServices.Services
{
    public class CocktailServices : ICocktailServices
    {
        public async Task<CocktailResultDto> GetCocktailByName(string cocktailName)
        {
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={cocktailName}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                var root = JsonConvert.DeserializeObject<CocktailRootDto>(json);

                var drink = root?.Drinks?.FirstOrDefault();
                if (drink != null)
                {
                    var dto = new CocktailResultDto
                    {
                        Id = drink.idDrink,
                        Name = drink.strDrink,
                        Category = drink.strCategory,
                        Glass = drink.strGlass,
                        Instructions = drink.strInstructions,
                        ImageUrl = drink.strDrinkThumb,
                        Ingredients = new List<string>(),
                        Measures = new List<string>()
                    };

                    for (int i = 1; i <= 15; i++)
                    {
                        var ingredient = drink.GetType().GetProperty($"strIngredient{i}")?.GetValue(drink)?.ToString();
                        var measure = drink.GetType().GetProperty($"strMeasure{i}")?.GetValue(drink)?.ToString();

                        if (!string.IsNullOrWhiteSpace(ingredient) && ingredient != "null")
                            dto.Ingredients.Add(ingredient);

                        if (!string.IsNullOrWhiteSpace(measure) && measure != "null")
                            dto.Measures.Add(measure);
                    }

                    return dto;
                }
            }

            return null;
        }
    }
}
