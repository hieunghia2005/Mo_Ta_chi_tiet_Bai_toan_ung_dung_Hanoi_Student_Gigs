using HanoiStudentGigs.Models;
using System.Collections.Generic;

namespace HanoiStudentGigs.Repositories
{
    public interface ICompanyReviewRepository
    {
        IEnumerable<CompanyReview> GetAll();
        void Add(CompanyReview review);
    }
}