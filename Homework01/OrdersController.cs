using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            return View();
        }
        public IActionResult JsonData()
        {
            var order = new OrdersDetails { Id = 12, Name = "Narachka 1" };
            return new JsonResult(order);
        }

        public IActionResult Rederect()
        {
          return RedirectToAction("Index", "Home");
        }
    }
}
