using Microsoft.AspNetCore.Mvc;
using HanoiStudentGigs.Models;

public class CompanyReviewsController : Controller
{
    public IActionResult Index()
    {
        var companies = new List<CompanyReview>
        {
            new() { Name = "FPT Software", Description = "Công ty công nghệ hàng đầu...", Image = "fpt.png", Rating = 4.7 },
            new() { Name = "VNG Corporation", Description = "Nổi tiếng với startup sáng tạo...", Image = "vng.png", Rating = 4.6 },
            new() { Name = "VinGroup", Description = "Tập đoàn đa ngành...", Image = "vingroup.png", Rating = 4.5 },
            new() { Name = "Tiki Tech", Description = "Thương mại điện tử phát triển...", Image = "tiki.png", Rating = 4.4 },
            new() { Name = "Techcombank", Description = "Ngân hàng TMCP hiện đại...", Image = "techcombank.png", Rating = 4.3 },
            new() { Name = "NashTech", Description = "Công ty outsource chuyên nghiệp...", Image = "nashtech.png", Rating = 4.2 },
        };

        return View(companies);
    }
}