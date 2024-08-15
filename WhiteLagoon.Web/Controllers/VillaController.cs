using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly AppDbContext _context;
        public VillaController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext Db { get; }

        public async Task <IActionResult> Index()
        {
            var villas = await _context.Villas.ToListAsync();
            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Villa obj)
        {
            if(ModelState.IsValid)
            {
                await _context.Villas.AddAsync(obj);
                _context.SaveChanges();
                TempData["success"] = "Villa Added Successfully!";
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            Villa? obj = await _context.Villas.FirstOrDefaultAsync(v=> v.Id == Id);


            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Villa obj)
        {
            if (ModelState.IsValid)
            {
                _context.Villas.Update(obj);
                await _context.SaveChangesAsync();
                TempData["success"] = "Villa Updated Successfully!";
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Villa? obj = await _context.Villas.FirstOrDefaultAsync(v => v.Id == id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePOST (int id)
        {
            Villa? obj = await _context.Villas.FirstOrDefaultAsync(v => v.Id == id);

            if (obj != null)
            {
                _context.Villas.Remove(obj);
                await _context.SaveChangesAsync();
                TempData["success"] = "Villa Deleted Successfully!";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Failed to delete Villa!";
            return View();


        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SendEmail(model);
                    TempData["Message"] = "Your message has been sent successfully!";
                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Failed to send email. Please try again later.");
                }
            }
            return View(model);
        }

        private void SendEmail(ContactViewModel model)
        {
            using (var client = new SmtpClient("smtp.example.com"))
            {
                client.Port = 587;
                client.Credentials = new NetworkCredential("your-email@example.com", "your-password");
                client.EnableSsl = true;

                var message = new MailMessage
                {
                    From = new MailAddress("your-email@example.com"),
                    Subject = "New Contact Form Submission",
                    Body = $"Name: {model.Name}\nEmail: {model.Email}\nMessage: {model.Message}",
                    IsBodyHtml = false,
                };
                message.To.Add("infinitydead65@gmail.com");

                client.Send(message);
            }
        }

    }
}
