using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //all the methods here will talk about data
        //all the methds will have IActionResult as an return type
        //all the methods will return HttpStatus Code - 100, 200, 300, 400, 500

        [HttpGet]
        public IActionResult Greet()
        {
            return Ok("Hello and welcome to WebAPI");
        }
        [HttpGet]
        [Route("greet/{name}")]
        public IActionResult Greetuser(string name)
        {
            return Ok(" Hello how are you doing today, " + name);
        }


    }
}
