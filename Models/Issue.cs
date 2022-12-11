using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Issue
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType IssueTypeIssueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Complated { get; set; }
    }
    public enum Priority
    {
        Low,Medium,Hight
    }
    public enum IssueType
    {
        Feature,Bug,Documentation
    }
}
