using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace shoppingAPPMVC.Controllers
{
    [Authorize]
    public class shoppingController : Controller
    {
        [AllowAnonymous]
        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult PreviousOrders()
        {
            return View();
        }

        public IActionResult WalletBalance()
        {
            return View();
        }

    }
}
