using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVCLearning.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Greet(string name)
        {
            ViewData["Name"] = name; 
            return View();
        }


        public IActionResult Edit()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewData["Message"] = message;
            return View("EditResult");
        }
    }
}
