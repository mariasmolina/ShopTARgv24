using ShopTARgv24.Core.Dto.CocktailDto;

namespace ShopTARgv24.Core.ServiceInterface
{
    public interface ICocktailServices
    {
        Task<CocktailResultDto> GetRandomCocktailRecipe(CocktailResultDto dto);
    }
}
