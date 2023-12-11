using Grocery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grocery.Controllers
{
    public class AdminController : Controller
    {
        Context c=new Context();
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult AdminProduct()
        {
            var values = c.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("AdminProduct");
        }

        public IActionResult DeleteProduct(int id)
        {
            var product=c.Products.Find(id);
            if (product != null)
            {
                c.Products.Remove(product);
            }
            c.SaveChanges();
            return RedirectToAction("AdminProduct");
        }
    }
}
