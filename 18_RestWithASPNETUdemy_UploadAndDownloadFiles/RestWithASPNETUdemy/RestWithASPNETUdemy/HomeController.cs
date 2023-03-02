using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public IActionResult Index()
        {
            return View();
        }
    }
}
