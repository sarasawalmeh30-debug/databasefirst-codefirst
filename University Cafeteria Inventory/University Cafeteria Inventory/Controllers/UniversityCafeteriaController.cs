using Microsoft.AspNetCore.Mvc;

namespace University_Cafeteria_Inventory.Controllers
{
    public class UniversityCafeteriaController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
