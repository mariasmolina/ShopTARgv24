using ShopTARgv24.Core.ServiceInterface;
using ShopTARgv24.Data;

namespace ShopTARgv24.ApplicationServices.Services
{
    public class RealEstateServices : IRealEstateServices
    {
        private readonly ShopTARgv24Context _context;

        public RealEstateServices
            (
                ShopTARgv24Context context
            )
        {
            _context = context;
        }
    }
}
