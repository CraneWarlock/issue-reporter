using IssueReporter.Entites;
using System.ComponentModel.DataAnnotations;

namespace IssueReporter.Models.IssueDto
{
    public class CreateIssueDto
    {
        [Required]
        public string RefId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Topic { get; set; }

        [Required]
        [MaxLength(1500)]
        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        public string Reporter { get; set; }

        public int ReporterId { get; set; }

        [Required]
        public string ReporterEmail { get; set; }

        public Status Status { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public int? AssigneeId { get; set; }
    }
}
