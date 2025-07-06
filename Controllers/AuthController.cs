using Microsoft.AspNetCore.Mvc;
using HanoiStudentGigs.Models;
using HanoiStudentGigs.Helpers;

namespace HanoiStudentGigs.Controllers
{
    public class AuthController : Controller
    {
        private static List<User> Users = new List<User>(); // Dùng tạm bộ nhớ, chưa dùng DB

        // GET: /Auth/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Auth/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = Users.FirstOrDefault(u => u.Email == email);
            if (user == null || !PasswordHasher.Verify(password, user.PasswordHash))
            {
                ViewBag.Error = "Email hoặc mật khẩu không đúng.";
                return View();
            }

            // Tạm lưu thông tin đăng nhập (giả lập session)
            HttpContext.Session.SetString("UserEmail", user.Email);
            HttpContext.Session.SetString("UserRole", user.Role);

            return RedirectToAction("Index", "Home");
        }

        // GET: /Auth/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Auth/Register
        [HttpPost]
        public IActionResult Register(string email, string password, string role)
        {
            if (Users.Any(u => u.Email == email))
            {
                ViewBag.Error = "Email đã được sử dụng.";
                return View();
            }

            var hashed = PasswordHasher.Hash(password);
            Users.Add(new User { Email = email, PasswordHash = hashed, Role = role });

            return RedirectToAction("Login");
        }

        // GET: /Auth/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}