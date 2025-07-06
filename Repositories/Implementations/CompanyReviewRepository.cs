using HanoiStudentGigs.Models;

namespace HanoiStudentGigs.Repositories
{
    public class CompanyReviewRepository : ICompanyReviewRepository
    {
        private static readonly List<CompanyReview> _reviews = new();

        public IEnumerable<CompanyReview> GetAll() => _reviews;

        public void Add(CompanyReview review)
        {
            review.Id = _reviews.Count + 1;
            _reviews.Add(review);
        }
        
    }
}