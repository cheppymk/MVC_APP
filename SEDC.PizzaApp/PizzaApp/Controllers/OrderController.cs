using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[controller]/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
                return new EmptyResult();

            ViewBag.OrderId = id;
            return View();
        }
        [Route("[controller]/JsonData")]
        public IActionResult JsonData()
        {
            var model = new ExampleModel { Id = 1, Name = "Example" };
            return Json(model);
        }
        public IActionResult GoToHome()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
