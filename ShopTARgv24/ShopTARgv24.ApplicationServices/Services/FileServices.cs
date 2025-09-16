using ShopTARgv24.Core.Dto;
using ShopTARgv24.Data;

namespace ShopTARgv24.ApplicationServices.Services
{
    public class FileServices
    {
        private readonly ShopTARgv24Context _context;

        public FileServices
            (
                ShopTARgv24Context context
            )
        {
            _context = context;
        }
        public void FilesToApi(SpaceshipDto dto)
        {
            
        }
    }
}
