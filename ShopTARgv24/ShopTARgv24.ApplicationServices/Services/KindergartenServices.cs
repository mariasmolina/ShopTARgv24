using ShopTARgv24.Core.ServiceInterface;
using ShopTARgv24.Data;

namespace ShopTARgv24.ApplicationServices.Services
{
    public class KindergartenServices : IKindergartenServices
    {
        private readonly ShopTARgv24Context _context;

        public KindergartenServices
            (
                ShopTARgv24Context context
            )
        {
            _context = context;
        }
    }
}
