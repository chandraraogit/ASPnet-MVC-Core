using Microsoft.AspNetCore.Mvc;
using mydemoproj.Models;

namespace mydemoproj.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            ProductViewModel productViewModel = new()
            {
                ProdCode = "P0012",
                ProdID = 1,
                ProductName = "Apple",
                ProductPrice = 999.99
               

            };
            ViewData["Prod"] = productViewModel;
            return View("Product");
        }

        [Route("add")]
        public IActionResult Create()
        {
            return View("Create");
        }

        [Route("save")]
        [HttpPost]
        public IActionResult SaveProduct(ProductViewModel productVM)
        {
            return View("ThanYou");
        }
    }
}
