using Microsoft.AspNetCore.Mvc;

namespace FTR.UI.Controllers
{
    public class FinanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
