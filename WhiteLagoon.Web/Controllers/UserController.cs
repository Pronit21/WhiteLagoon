using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            /*_context.Users.Add(new User
            {
                Email = loginViewModel.Email,
                Password = loginViewModel.Password
            });*/
            _context.SaveChanges();

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel registerViewModel)
        {
            return View();
        }
    }
}
