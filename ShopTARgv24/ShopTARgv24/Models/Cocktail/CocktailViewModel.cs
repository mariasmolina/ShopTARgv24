namespace ShopTARgv24.Models.Cocktail
{
    public class CocktailViewModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Glass { get; set; }
        public string Instructions { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Ingredients { get; set; } = new();
        public List<string> Measures { get; set; } = new();
    }
}
