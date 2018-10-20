using Microsoft.AspNetCore.Mvc;

namespace SPCMonitor.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel loginModel)
        {
            return View();
        }
    }

    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}