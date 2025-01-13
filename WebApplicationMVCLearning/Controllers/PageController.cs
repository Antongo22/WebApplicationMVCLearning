using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVCLearning.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
