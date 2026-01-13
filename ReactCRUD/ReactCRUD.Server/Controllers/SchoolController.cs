using Microsoft.AspNetCore.Mvc;

namespace ReactCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        [HttpGet(Name = "SchoolList")]
        public IActionResult Index()
        {
            var result = "";



            return Ok(result);
        }
    }
}
