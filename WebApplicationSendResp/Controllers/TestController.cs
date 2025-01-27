using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationSendResp.Controllers
{
    public class TestController : Controller
    {
        public async Task Text()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("Hello, world!");
        }

        public async Task Html()
        {
            Response.ContentType = "text/html";
            await Response.WriteAsync("<html><head><title>Test Page</title></head><body><h1>Hello, world!</h1><p>This is a test HTML page.</p></body></html>");
        }

        public async Task Json()
        {
            var data = new { Name = "Anton", Age = 18 };
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(data);
        }

        public async Task<IActionResult> File()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "test.txt");
            System.IO.File.WriteAllText(filePath, "This is a test file");
            Response.ContentType = "text/plain";
            await Response.SendFileAsync(filePath);
            return new EmptyResult();
        }

        public async Task Status()
        {
            Response.StatusCode = 404;
            await Response.WriteAsync("404 - Not Found");
        }

        public async Task Cookie()
        {
            Response.Cookies.Append("user", "Answer");
            await Response.WriteAsync("Cookie 'user' has been set with value 'Answer'.");
        }
    }
}