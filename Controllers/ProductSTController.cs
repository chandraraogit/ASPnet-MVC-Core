using Microsoft.AspNetCore.Mvc;
using mydemoproj.Models;

namespace mydemoproj.Controllers
{
    public class ProductSTController : Controller
    {
        public IActionResult ProductStronglyType()
        {
            ProductViewModel model = new()
            { 
            ProdID = 9,
            ProdCode="AP001",
            ProductName="Rice",
            ProductPrice=54.89,
            //prodManDtls =null
            };
            return View("ProductStronglyType", model);
        }
    }
}
