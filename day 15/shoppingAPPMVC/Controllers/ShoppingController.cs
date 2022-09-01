using Microsoft.AspNetCore.Mvc;

namespace shoppingAPPMVC.Controllers
{
    public class ShoppingController : Controller
    {
      
        public IActionResult Products()
        {
            //collect the data from model and pass it to view or vice versa
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
