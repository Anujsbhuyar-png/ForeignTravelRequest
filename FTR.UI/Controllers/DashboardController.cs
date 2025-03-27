using Microsoft.AspNetCore.Mvc;
using FTR.BL;
using System.Threading.Tasks;
using FTR.BL.ViewModels;
namespace FTR.UI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var dashboardViewModels = await _dashboardService.GetDashboardViewModelsAsync();
            return View(dashboardViewModels);
        }
    }
}
