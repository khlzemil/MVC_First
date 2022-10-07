using Microsoft.AspNetCore.Mvc;

namespace HomeWork0410.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Emil";
            ViewBag.Surname = "Quluzade";
            ViewBag.Age = 20;
            ViewBag.Country = "Baku";
            ViewBag.PhoneNumber = "+994513633533";
            return View();
        }
    }
}
