using Microsoft.AspNetCore.Identity;

namespace IssueReporter.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string  PasswordHash { get; set; }
        public virtual Role Role { get; set; }
        public virtual List<Issue> Issues { get; set; }
    }
}
