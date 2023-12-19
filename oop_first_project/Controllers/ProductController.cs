using Microsoft.AspNetCore.Mvc;
using oop_first_project.Entity;
using oop_first_project.ProjeContext;

namespace oop_first_project.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p )
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id) {
            var value=context.Products.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges() ;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id) {
            var value=context.Products.Where(x=>x.Id == id).FirstOrDefault();
            return View(value);
        }
    }
}
