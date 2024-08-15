using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaNumberController: Controller
    {
        private readonly AppDbContext _context;

        public VillaNumberController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var villaNumbers = await _context.VillaNumbers.ToListAsync();
            return View(villaNumbers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VillaNumber obj)
        {
            if (ModelState.IsValid)
            {
                await _context.VillaNumbers.AddAsync(obj);
                _context.SaveChanges();
                TempData["success"] = "The Villa Number has been Added Successfully!";
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}
