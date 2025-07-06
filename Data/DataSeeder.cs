using HanoiStudentGigs.Models;

namespace HanoiStudentGigs.Data
{
    public static class DataSeeder
    {
        public static void SeedJobs(ApplicationDbContext context)
        {
            if (!context.Employers.Any())
            {
                var employer1 = new Employer { Name = "FPT Software", IsVerified = true };
                var employer2 = new Employer { Name = "VinGroup", IsVerified = true };

                context.Employers.AddRange(employer1, employer2);
                context.SaveChanges();
            }

            if (!context.Jobs.Any())
            {
                var jobs = new List<Job>
                {
                    new Job
                    {
                        Title = "Nhân viên bán hàng cuối tuần",
                        Description = "Làm tại Aeon Mall Hà Đông. Lương 30k/h",
                        Location = "Hà Đông, Hà Nội",
                        Salary = "30.000đ/giờ",
                        EmployerId = context.Employers.First().Id,
                        IsApproved = true
                    },
                    new Job
                    {
                        Title = "Thiết kế logo freelance",
                        Description = "Yêu cầu biết Canva hoặc AI. Lương theo sản phẩm",
                        Location = "Remote",
                        Salary = "Tùy sản phẩm",
                        EmployerId = context.Employers.Skip(1).First().Id,
                        IsApproved = true
                    }
                };

                context.Jobs.AddRange(jobs);
                context.SaveChanges();
            }

            if (!context.CompanyReviews.Any())
            {
                var reviews = new List<CompanyReview>
                {
                    new CompanyReview
                    {
                        CompanyName = "FPT Software",
                        Content = "Môi trường làm việc chuyên nghiệp, năng động.",
                        Rating = 5,
                        ReviewerName = "Nguyễn Văn A",
                        CreatedAt = DateTime.Now
                    },
                    new CompanyReview
                    {
                        CompanyName = "VinGroup",
                        Content = "Áp lực cao nhưng được học hỏi rất nhiều.",
                        Rating = 4,
                        ReviewerName = "Trần Thị B",
                        CreatedAt = DateTime.Now
                    }
                };

                context.CompanyReviews.AddRange(reviews);
                context.SaveChanges();
            }
        }
    }
}
