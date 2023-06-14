using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel>dogs = new List<DogViewModel>();
        public IActionResult Index()
        {   
            return View(dogs);
        }
        public IActionResult Create()
        {   var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {    dogs.Add(dogViewModel);
            //return View("index");
            return RedirectToAction(nameof(Index));
        }
    }
}
