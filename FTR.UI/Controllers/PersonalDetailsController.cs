using Microsoft.AspNetCore.Mvc;
using FTR.BL;

namespace FTR.UI.Controllers
{
    public class PersonalDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IPersonalDetailsService _personalDetailsService;

        public PersonalDetailsController(IPersonalDetailsService personalDetailsService)
        {
            _personalDetailsService = personalDetailsService;
        }

        public IActionResult Details()
        {
            var personalDetails = _personalDetailsService.GetPersonalDetails();
            return View(personalDetails);
        }


    }
}
