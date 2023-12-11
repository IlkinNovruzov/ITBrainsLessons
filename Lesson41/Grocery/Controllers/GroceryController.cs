using Microsoft.AspNetCore.Mvc;

namespace Grocery.Controllers
{
    public class GroceryController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
       


    }
}
