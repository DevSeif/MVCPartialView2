using Microsoft.AspNetCore.Mvc;

namespace PeopleMVC.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
