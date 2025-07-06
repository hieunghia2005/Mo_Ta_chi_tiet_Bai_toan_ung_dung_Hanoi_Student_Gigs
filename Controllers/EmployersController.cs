using Microsoft.AspNetCore.Mvc;
using HanoiStudentGigs.Models;

namespace HanoiStudentGigs.Controllers
{
    public class EmployersController : Controller
    {
        // Trang chính dành cho nhà tuyển dụng
        public IActionResult Index()
        {
            return View();
        }

        // Trang form đăng tin việc làm
        [HttpGet]
        public IActionResult CreateJob()
        {
            return View();
        }

        // Xử lý form đăng tin việc làm
        [HttpPost]
        public IActionResult CreateJob(Job job)
        {
            if (ModelState.IsValid)
            {
                // TODO: Lưu Job vào database
                return RedirectToAction("MyJobs");
            }

            return View(job);
        }

        // Xem danh sách tin đã đăng
        public IActionResult MyJobs()
        {
            // TODO: Lấy danh sách jobs của employer hiện tại
            return View();
        }
    }
}