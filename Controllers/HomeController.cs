using Microsoft.AspNetCore.Mvc;

namespace HanoiStudentGigs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Trang chủ
        }
    }
}