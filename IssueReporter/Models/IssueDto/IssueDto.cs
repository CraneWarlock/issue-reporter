using System.Text.Json.Serialization;
using IssueReporter.Entites;

namespace IssueReporter.Models.IssueDto
{
    public class IssueDto
    {
        public int Id { get; set; }
        public string RefId { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Reporter { get; set; }
        public string ReporterEmail { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Resolved { get; set; }
        public int? AssigneeId { get; set; }
        public virtual User User { get; set; }

    }
}
