using System;
using System.ComponentModel.DataAnnotations;

namespace FluentTaskManager.Server.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }

    public class Task
    {
        public int Id { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [StringLength(500)] public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TimeSpan ExpectedDuration { get; set; }

        public TaskPriority Priority { get; set; }

        public TaskStatus Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? CompletedDate { get; set; }

        public User AssignedUser { get; set; }
    }
}