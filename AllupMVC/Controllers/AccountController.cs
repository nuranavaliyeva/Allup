using Microsoft.AspNetCore.Mvc;

namespace AllupMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
