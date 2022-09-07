using IssueReporter.Entites;

namespace IssueReporter.Models.IssueDto
{
    public class UpdateIssueDto
    {
        public string Topic { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Resolved { get; set; }
        public int? AssigneeId { get; set; }
    }
}
