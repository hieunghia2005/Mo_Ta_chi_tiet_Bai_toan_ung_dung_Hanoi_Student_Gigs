using Microsoft.AspNetCore.Mvc;
using HanoiStudentGigs.Models;

namespace HanoiStudentGigs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationsController : ControllerBase
    {
        // ⚠️ Lưu trữ tạm trong bộ nhớ (chưa kết nối DB thực)
        private static List<Application> _applications = new();

        // ✅ POST: api/applications — sinh viên nộp đơn ứng tuyển
        [HttpPost]
        public IActionResult Apply([FromBody] Application application)
        {
            if (application == null || application.StudentId <= 0 || application.JobId <= 0)
            {
                return BadRequest("Dữ liệu không hợp lệ.");
            }

            application.Id = _applications.Count + 1;
            application.AppliedAt = DateTime.UtcNow;

            _applications.Add(application);

            return Ok(application);
        }

        // ✅ GET: api/applications/job/{jobId} — lấy danh sách ứng viên cho một job cụ thể
        [HttpGet("job/{jobId}")]
        public IActionResult GetByJob(int jobId)
        {
            var result = _applications.Where(a => a.JobId == jobId).ToList();
            return Ok(result);
        }

        // ✅ GET: api/applications/student/{studentId} — lấy danh sách công việc mà sinh viên đã ứng tuyển
        [HttpGet("student/{studentId}")]
        public IActionResult GetByStudent(int studentId)
        {
            var result = _applications.Where(a => a.StudentId == studentId).ToList();
            return Ok(result);
        }
    }
}