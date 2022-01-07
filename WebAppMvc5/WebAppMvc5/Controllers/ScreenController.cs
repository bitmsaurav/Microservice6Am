using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc5.Controllers
{
    public class ScreenController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
