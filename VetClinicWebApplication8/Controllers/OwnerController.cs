using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetClinicWebApplication8.Data;
using VetClinicWebApplication8.Models;

namespace VetClinicWebApplication8.Controllers
{
    public class OwnerController : Controller
    {
        private readonly AppDbContext _context;

        public OwnerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Owners/Create
        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Owners/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Owner_Pet ownerPet)
        {
            if (ModelState.IsValid)
            {
                _context.Owners.Add(ownerPet);
                _context.SaveChanges();
                return RedirectToAction("Index", "Owner"); // Redirect to the Owner index page after creation
            }

            return View(ownerPet);
        }

        // GET: Owners/Index
       
      
        public IActionResult Index()
        {
            var owners = _context.Owners.ToList();
            return View(owners);
        }

        // GET: Owners/Details/{id}
        
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownerPet = _context.Owners.FirstOrDefault(o => o.OwnerId == id);
            if (ownerPet == null)
            {
                return NotFound();
            }

            return View(ownerPet);
        }

        // GET: Owners/Edit/5
        [HttpGet]
        [Authorize]
        public IActionResult Edit(int id)
        {
            var ownerPet = _context.Owners.FirstOrDefault(o => o.OwnerId == id);
            if (ownerPet == null)
            {
                return NotFound();
            }
            return View(ownerPet);
        }

        // POST: Owners/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Owner_Pet owner)
        {
            if (id != owner.OwnerId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Owners.Update(owner);
                _context.SaveChanges();
                return RedirectToAction("Index"); // Redirect to list page after editing
            }

            return View(owner);
        }


        // GET: Owners/Delete/{id}
        [HttpGet]
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownerPet = _context.Owners.Find(id);
            if (ownerPet == null)
            {
                return NotFound();
            }

            return View(ownerPet);
        }

        // POST: Owners/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var ownerPet = _context.Owners.Find(id);
            if (ownerPet != null)
            {
                _context.Owners.Remove(ownerPet);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Owner");
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var owners = from o in _context.Owners
                         select o;

            if (!string.IsNullOrEmpty(searchString))
            {
                owners = owners.Where(o => o.OwnerName.Contains(searchString) || o.PetName.Contains(searchString));
            }

            return View(owners.ToList());
        }

    }
}