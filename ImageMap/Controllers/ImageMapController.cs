using Microsoft.AspNetCore.Mvc;

namespace ImageMap.Controllers
{
    public class ImageMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
