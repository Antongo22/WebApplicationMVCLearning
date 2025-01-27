using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationGetResp.Controllers
{
    public class EchoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task Get()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("GET request received");
        }

        [HttpPost]
        public async Task Post()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("POST request received");
        }

        [HttpGet]
        public async Task Headers()
        {
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(Request.Headers);
        }

        [HttpGet]
        public async Task Query()
        {
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(Request.Query);
        }

        [HttpPost]
        public async Task Body()
        {
            Response.ContentType = "text/plain";
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var body = await reader.ReadToEndAsync();
                await Response.WriteAsync(body);
            }
        }
    }
}