namespace IssueReporter.Entites
{
    public class Issue
    {
        public int Id { get; set; }
        public string RefId { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Reporter { get; set; }
        public string ReporterId { get; set; }
        public string ReporterEmail { get; set; }
        public Status Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Resolved { get; set; }
        public virtual User User { get; set; }
    }

    public enum Status
    {
        Assigned,
        Unassigned,
        InProgress,
        Resolved
    }
}
