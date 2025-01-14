using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VetClinicWebApplication8.Data;

namespace VetClinicWebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Owner()
        {
            return View();
        }


        public IActionResult Index()
        {
            var model = new
            {
                TotalOwners = _context.Owners.Select(o => o.OwnerName).Distinct().Count(),
                TotalPets = _context.Owners.Count(),
                UpcomingVaccinations = _context.Owners.Count(o => o.NextVac_Date > DateTime.Now && o.NextVac_Date <= DateTime.Now.AddDays(30))
            };

            return View(model);
        }
    }
}
