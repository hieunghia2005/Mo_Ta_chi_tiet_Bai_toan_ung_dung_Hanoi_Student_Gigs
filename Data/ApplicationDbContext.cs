using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HanoiStudentGigs.Models;

namespace HanoiStudentGigs.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<ApplicationUser> Users { get; set; } // dòng này KHÔNG cần thiết, sẽ lỗi!
        public DbSet<Employer> Employers { get; set; }
        public DbSet<CompanyReview> CompanyReviews { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<JobPost> JobPosts { get; set; }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}