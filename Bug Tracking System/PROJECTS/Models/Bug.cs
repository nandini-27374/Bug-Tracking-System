using System.ComponentModel.DataAnnotations;

namespace PROJECTS.Models
{
    public class Bug
    {
        public int Id { get; set; } // Primary key
        [Required, StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Severity { get; set; } // "Low", "Medium", "High"
        [Required]
        public string Status { get; set; } // "Open", "In Progress", "Closed"
        public string Assignee { get; set; }
        public DateTime ReportedDate { get; set; }
    }
}
