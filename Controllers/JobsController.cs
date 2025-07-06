using Microsoft.AspNetCore.Mvc;
using HanoiStudentGigs.Data; // <-- NHỚ THÊM DÒNG NÀY
using HanoiStudentGigs.Models;
using System.Linq;

namespace HanoiStudentGigs.Controllers
{
    public class JobsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Jobs/SearchByCategory?category=Thiết kế
        public IActionResult SearchByCategory(string category)
        {
            var categories = _context.JobPosts
                .Select(j => j.Category)
                .Where(c => !string.IsNullOrEmpty(c))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            ViewBag.Categories = categories;

            var jobs = string.IsNullOrEmpty(category)
                ? _context.JobPosts.OrderByDescending(j => j.CreatedAt).ToList()
                : _context.JobPosts
                    .Where(j => j.Category == category)
                    .OrderByDescending(j => j.CreatedAt)
                    .ToList();

            return View(jobs); // Nhớ tạo file Views/Jobs/SearchByCategory.cshtml
        }
    }
}