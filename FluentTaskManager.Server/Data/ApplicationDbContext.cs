using Microsoft.EntityFrameworkCore;
using FluentTaskManager.Server.Models;
using Task = FluentTaskManager.Server.Models.Task;

namespace FluentTaskManager.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(t => t.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}