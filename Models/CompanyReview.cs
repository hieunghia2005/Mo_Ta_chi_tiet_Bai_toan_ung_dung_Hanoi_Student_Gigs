using System.ComponentModel.DataAnnotations;

namespace HanoiStudentGigs.Models
{
    public class CompanyReview
    {
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        [Range(1, 5)]
        public double Rating { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string? ReviewerName { get; set; } // Optional: Student name
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Image { get; set; }
            
    }
    
}