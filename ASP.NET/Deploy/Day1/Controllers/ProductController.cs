using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //End Point : Product/getProducts
        public IActionResult getProducts() => View("showAll",new ProductBL().getAll());


        //End Point : Product/getProductByIndex/index
        public IActionResult getProductByIndex(int index) => View("ShowProduct", new ProductBL().getByIndex(index));
        



    }
}
