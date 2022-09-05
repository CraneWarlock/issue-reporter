using Microsoft.EntityFrameworkCore;

namespace IssueReporter.Entites
{
    public class IssueReporterDbContext : DbContext
    {
        private string _dbConnectionString =
            "Server=(localdb)\\mssqllocaldb;Database=IssueReporterDb;Trusted_Connection=True;";

        public DbSet<Issue> Issues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User
            modelBuilder.Entity<User>()
                .Property(r => r.Email)
                .IsRequired();

            // Role
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired();

            //Issue
            modelBuilder.Entity<Issue>()
                .Property(r => r.Topic)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Issue>()
                .Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(1500);

            modelBuilder.Entity<Issue>()
                .Property(r => r.Created)
                .IsRequired();

            modelBuilder.Entity<Issue>()
                .Property(r => r.ReporterEmail)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnectionString);
        }
    }
}
