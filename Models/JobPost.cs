using HanoiStudentGigs.Models;

namespace HanoiStudentGigs.Models
{
    public class JobPost
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        // Thêm dòng này nếu chưa có:
        public int EmployerId { get; set; }

        // (tuỳ chọn) navigation property nếu bạn có bảng Employer
        public Employer Employer { get; set; }
    }
}
