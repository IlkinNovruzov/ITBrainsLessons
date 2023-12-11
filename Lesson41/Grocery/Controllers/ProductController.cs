using Microsoft.AspNetCore.Mvc;
using Grocery.Models;
namespace Grocery.Controllers
{
    public class ProductController : Controller
    {
        Context c=new Context();
        public IActionResult Product()
        {
            var values = c.Products.ToList();
            return View(values);
        }
        public IActionResult Details(int id)
        {
            var p=c.Products.Find(id);

            return View(p);
        }
    }
}
