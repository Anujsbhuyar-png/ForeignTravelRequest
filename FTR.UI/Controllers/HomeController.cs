using System.Diagnostics;
using FTR.DL;
using FTR.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FTR.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dashboardViewModels = await _context.ForeignTravelRequest
                .Include(f => f.Employee)
                .Include(f => f.Status)
                .Select(f => new DashboardViewModel
                {
                    EmployeeName = f.Employee.EmployeeName,
                    Department = f.Employee.Department,
                    FtrId = f.FtrId,
                    VisaType = f.VisaType,
                    StatusId = f.StatusId,
                    StatusName = f.Status.statusName,
                    CurrentStep = f.CurrentStep
                })
                .ToListAsync();

            return View(dashboardViewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
